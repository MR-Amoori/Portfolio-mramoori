using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.DataLayer.Context;
using Portfolio.DataLayer.Models;
using System.Globalization;

namespace Portfolio.Controllers
{
    public class SitemapController : Controller
    {
        private readonly PortfolioContext _context;

        public SitemapController(PortfolioContext context)
        {
            _context = context;
        }

        [Route("sitemap.xml")]
        public IActionResult Index()
        {
            var baseUrl = "https://mramoori.ir";
            var sitemap = new StringBuilder();
            sitemap.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
            sitemap.AppendLine("<urlset xmlns=\"https://www.sitemaps.org/schemas/sitemap/0.9\">");

            // صفحه اصلی
            sitemap.AppendLine("  <url>");
            sitemap.AppendLine($"    <loc>{baseUrl}/</loc>");
            sitemap.AppendLine($"    <lastmod>{DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}</lastmod>");
            sitemap.AppendLine("    <changefreq>daily</changefreq>");
            sitemap.AppendLine("    <priority>1.0</priority>");
            sitemap.AppendLine("  </url>");

            // بخش‌های داخلی صفحه اصلی
            sitemap.AppendLine("  <!-- Main Page Sections -->");
            var sections = new[] { "about-me", "contact-links", "skills", "services", "business-licenses", "certificates", "portfolio", "blog", "contact" };
            foreach (var section in sections)
            {
                sitemap.AppendLine("  <url>");
                sitemap.AppendLine($"    <loc>{baseUrl}/#{section}</loc>");
                sitemap.AppendLine($"    <lastmod>{DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}</lastmod>");
                sitemap.AppendLine("    <changefreq>weekly</changefreq>");
                sitemap.AppendLine("    <priority>0.8</priority>");
                sitemap.AppendLine("  </url>");
            }

            // نمونه کارها - استفاده از لینک واقعی پروژه
            sitemap.AppendLine("  <!-- Portfolio Projects -->");
            var portfolios = _context.Portfolios.ToList();
            foreach (var portfolio in portfolios)
            {
                if (!string.IsNullOrEmpty(portfolio.Link))
                {
                    sitemap.AppendLine("  <url>");
                    sitemap.AppendLine($"    <loc>{portfolio.Link}</loc>");
                    sitemap.AppendLine($"    <lastmod>{DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}</lastmod>");
                    sitemap.AppendLine("    <changefreq>monthly</changefreq>");
                    sitemap.AppendLine("    <priority>0.6</priority>");
                    sitemap.AppendLine("  </url>");
                }
            }

            // جواز کسب - استفاده از لینک صحت سنجی
            sitemap.AppendLine("  <!-- Business Licenses -->");
            var businessLicenses = _context.BusinessLicenses.ToList();
            foreach (var license in businessLicenses)
            {
                if (!string.IsNullOrEmpty(license.VerificationLink))
                {
                    sitemap.AppendLine("  <url>");
                    sitemap.AppendLine($"    <loc>{license.VerificationLink}</loc>");
                    sitemap.AppendLine($"    <lastmod>{DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}</lastmod>");
                    sitemap.AppendLine("    <changefreq>monthly</changefreq>");
                    sitemap.AppendLine("    <priority>0.6</priority>");
                    sitemap.AppendLine("  </url>");
                }
            }

            // مدارک - استفاده از لینک صحت سنجی
            sitemap.AppendLine("  <!-- Certificates -->");
            var certificates = _context.Certificates.ToList();
            foreach (var cert in certificates)
            {
                if (!string.IsNullOrEmpty(cert.VerificationLink))
                {
                    sitemap.AppendLine("  <url>");
                    sitemap.AppendLine($"    <loc>{cert.VerificationLink}</loc>");
                    sitemap.AppendLine($"    <lastmod>{DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}</lastmod>");
                    sitemap.AppendLine("    <changefreq>monthly</changefreq>");
                    sitemap.AppendLine("    <priority>0.6</priority>");
                    sitemap.AppendLine("  </url>");
                }
            }

            // وبلاگ - استفاده از لینک واقعی وبلاگ
            sitemap.AppendLine("  <!-- Blog Posts -->");
            var blogs = _context.Blogs.Where(b => !b.IsDeleted).ToList();
            foreach (var blog in blogs)
            {
                if (!string.IsNullOrEmpty(blog.Link))
                {
                    sitemap.AppendLine("  <url>");
                    sitemap.AppendLine($"    <loc>{blog.Link}</loc>");
                    var lastmod = blog.CreateDate != DateTime.MinValue ? blog.CreateDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) : DateTime.Now.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    sitemap.AppendLine($"    <lastmod>{lastmod}</lastmod>");
                    sitemap.AppendLine("    <changefreq>weekly</changefreq>");
                    sitemap.AppendLine("    <priority>0.5</priority>");
                    sitemap.AppendLine("  </url>");
                }
            }

            sitemap.AppendLine("</urlset>");

            return Content(sitemap.ToString(), "application/xml");
        }

        private string GenerateSlug(string title)
        {
            if (string.IsNullOrEmpty(title))
                return "untitled";

            // تبدیل کاراکترهای فارسی به معادل انگلیسی
            var transliterated = TransliteratePersian(title);

            // تبدیل به حروف کوچک و جایگزینی فاصله با خط تیره
            var slug = transliterated.ToLower()
                .Replace(" ", "-")
                .Replace("?", "")
                .Replace("!", "")
                .Replace("،", "")
                .Replace("؟", "")
                .Replace(".", "")
                .Replace(",", "")
                .Replace(";", "")
                .Replace(":", "")
                .Replace("'", "")
                .Replace("\"", "");

            // حذف کاراکترهای غیر مجاز
            var validChars = "abcdefghijklmnopqrstuvwxyz0123456789-";
            var result = new StringBuilder();
            foreach (var c in slug)
            {
                if (validChars.Contains(c))
                    result.Append(c);
            }

            // حذف خط تیره‌های تکراری
            var final = result.ToString();
            while (final.Contains("--"))
            {
                final = final.Replace("--", "-");
            }

            // حذف خط تیره از ابتدا و انتها
            final = final.Trim('-');

            return final.Length > 0 ? final : "untitled";
        }

        private string TransliteratePersian(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            var persianToEnglish = new Dictionary<string, string>
            {
                {"ا", "a"}, {"آ", "a"}, {"ب", "b"}, {"پ", "p"}, {"ت", "t"}, {"ث", "s"},
                {"ج", "j"}, {"چ", "ch"}, {"ح", "h"}, {"خ", "kh"}, {"د", "d"}, {"ذ", "z"},
                {"ر", "r"}, {"ز", "z"}, {"ژ", "zh"}, {"س", "s"}, {"ش", "sh"}, {"ص", "s"},
                {"ض", "z"}, {"ط", "t"}, {"ظ", "z"}, {"ع", "a"}, {"غ", "gh"}, {"ف", "f"},
                {"ق", "gh"}, {"ک", "k"}, {"گ", "g"}, {"ل", "l"}, {"م", "m"}, {"ن", "n"},
                {"و", "v"}, {"ه", "h"}, {"ی", "y"}, {"ئ", "y"}, {" ", "-"}
            };

            var result = new StringBuilder();
            foreach (var c in text)
            {
                var charStr = c.ToString();
                if (persianToEnglish.ContainsKey(charStr))
                {
                    result.Append(persianToEnglish[charStr]);
                }
                else if (char.IsLetterOrDigit(c))
                {
                    result.Append(c);
                }
                else
                {
                    result.Append('-');
                }
            }

            return result.ToString();
        }
    }
}
