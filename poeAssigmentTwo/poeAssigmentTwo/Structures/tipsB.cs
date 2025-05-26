using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poeAssigmentTwo.Structures
{
    public class tipsB
    {
        public List<responseB> GetCybersecurityTips()
        {
            return new List<responseB>
            {
                // Password Security
                new responseB
                {
                    Triggers = new[] { "passwords", "password", "1", "credentials" },
                    Title = "Password Security",
                    RandomResponses = new[]
                    {
                        // Original response
                        "Digital safety still relies heavily on password security. Instead of " +
                        "creating and storing simple or repetitive passwords, use a password " +
                        "manager to create and save complex, one-of-a-kind credentials for every " +
                        "account. Multi-factor authentication (MFA) should be enabled whenever " +
                        "possible to provide an extra layer of protection on top of a simple password.",
                        
                        // Option 2 from PDF
                        "To keep your online accounts safe, you must create and use strong passwords. " +
                        "Combining capital and lowercase letters, numbers, and symbols, a strong password " +
                        "should be at least 12–14 characters long and should not contain dictionary words " +
                        "or first names. It must be distinct and not duplicated between accounts. You can " +
                        "create and save secure passwords with Microsoft Edge. Never exchange passwords, " +
                        "use a password manager for several accounts, and turn on multi-factor authentication " +
                        "(MFA) for an additional degree of security. Keep passwords secure if you write them " +
                        "down or use hints. Watch out for phishing schemes; never give out passwords over " +
                        "the phone or by email and always double-check website URLs before entering login information.",
                        
                        // Option 3 from PDF
                        "Strong credentials are crucial for safeguarding personal information since hackers can " +
                        "take advantage of weak passwords. Important extra insights consist of:\n" +
                        "- Avoid Personal Information: Since hackers frequently start with easily discovered\n" +
                        "  information, such as names, addresses, or birthdays, you should never utilise it.\n" +
                        "- Length Is Important: Longer passwords (10+ characters) are much more secure,\n" +
                        "  even if six characters is the minimum.\n" +
                        "- Uniqueness Per Account: Using the same password for many accounts increases\n" +
                        "  the danger since if one is compromised, others are at risk.\n" +
                        "- Randomness Over Patterns: words from dictionaries or basic keyboard patterns\n" +
                        "  (like \"123abccba321\") are straightforward to figure out. It's best to use randomness\n" +
                        "  or a password generator.\n" +
                        "- Mnemonic Devices: Make memory aids for complicated generated passwords (for\n" +
                        "  example, linking \"H=jNp2#\" to a phrase such as \"HARRY = jessica NORTH paris 2 #\").\n" +
                        "- Password managers: By securely storing passwords, programs like LastPass or\n" +
                        "  Chrome's built-in manager remove the need to commit them to memory."
                    },
                    FollowUps = new[] { "managers", "authentication", "recovery" },
                    FollowUpResponses = new Dictionary<string, string[]>
                    {
                        ["managers"] = new[]
                        {
                            "Password managers like LastPass or Bitwarden securely store all your passwords in an encrypted vault.",
                            "Good password managers can generate and auto-fill complex passwords, and sync across all your devices securely.",
                            "By securely storing passwords, programs like LastPass or Chrome's built-in manager remove the need to commit them to memory."
                        },
                        ["authentication"] = new[]
                        {
                            "Multi-factor authentication (MFA) adds an extra layer by requiring a second verification method like SMS codes or authenticator apps.",
                            "Even if someone gets your password, MFA can prevent unauthorized access to your accounts.",
                            "Turn on multi-factor authentication (MFA) for an additional degree of security on top of your password."
                        },
                        ["recovery"] = new[]
                        {
                            "Set up account recovery options carefully - security questions should be hard for others to guess.",
                            "If you must write down passwords, keep them in a locked place and don't label them obviously.",
                            "Keep passwords secure if you write them down or use hints. Make sure hints aren't easily guessable."
                        }
                    }
                },

                // Security Software
                new responseB
                {
                    Triggers = new[] { "security software", "antivirus", "2", "protection" },
                    Title = "Security Software",
                    RandomResponses = new[]
                    {
                        // Original response
                        "High-quality anti-virus and anti-malware software offers crucial defence " +
                        "against online dangers. Choose trustworthy security programs, maintain " +
                        "their updates, and do routine scans. These tools act as a crucial line " +
                        "of defence against malware that could evade other security measures.",
                        
                        // Option 2 from PDF
                        "A proactive strategy for defending systems against vulnerabilities, data breaches, and " +
                        "cyberattacks is software security. It entails incorporating safeguards at every stage of the " +
                        "software development process to guarantee that systems are safe against cyberattacks. " +
                        "This is important since software is used in many different industries, and even one flaw can " +
                        "have disastrous results. By \"shifting left,\" companies may implement security early and " +
                        "prevent expensive retrofits, resulting in more resilient systems. To put it briefly, software " +
                        "security aims to prevent issues in the first place rather than only address them. In a world " +
                        "that is becoming more digital, a well-secured system safeguards data, fosters trust, and " +
                        "guarantees dependability.",
                        
                        // Option 3 from PDF
                        "An organized method for reducing dangers in digital systems is software security. Software " +
                        "security guarantees that systems secure data and operate as intended—without unauthorized " +
                        "access or interruptions—much like a financial audit ensures that funds are handled appropriately.\n\n" +
                        "What makes it so important?\n" +
                        "- Confidentiality: Private information, such as financial or medical records, must remain confidential.\n" +
                        "- Integrity: Malicious alteration of information is never acceptable.\n" +
                        "- Availability: Even in the face of an attack, systems must continue to function.\n\n" +
                        "Software security is ultimately about controlling risk before it becomes an emergency. In a time " +
                        "when digital safety is a must, companies who put it first not only protect their resources but also " +
                        "gain the trust of their people."
                    },
                    FollowUps = new[] { "selection", "scans", "features" },
                    FollowUpResponses = new Dictionary<string, string[]>
                    {
                        ["selection"] = new[]
                        {
                            "Choose security software from reputable vendors with regular update schedules.",
                            "Look for solutions that offer real-time protection rather than just on-demand scanning.",
                            "Consider your specific needs - home users have different requirements than businesses."
                        },
                        ["scans"] = new[]
                        {
                            "Schedule full system scans weekly, with quick scans daily for optimal protection.",
                            "Run additional scans after installing new software or visiting high-risk websites.",
                            "Scan all external devices like USB drives before opening any files from them."
                        },
                        ["features"] = new[]
                        {
                            "Modern security suites often include firewalls, phishing protection, and secure browsing tools.",
                            "Some solutions offer password managers and VPNs as part of their security packages.",
                            "Advanced features may include ransomware protection and webcam/microphone monitoring."
                        }
                    }
                },

                // Software Updates
                new responseB
                {
                    Triggers = new[] { "software updates", "updates", "3", "patches" },
                    Title = "Software Updates",
                    RandomResponses = new[]
                    {
                        // Original response
                        "One of the most popular places for hackers to enter a system is through " +
                        "outdated software. Turn on automatic updates for your apps, web browsers, " +
                        "and operating system. Because security patches frequently address serious " +
                        "flaws that hackers actively take advantage of, pay close attention to them. " +
                        "For improved security, modern browsers like Chrome and Firefox offer regular, " +
                        "automatic upgrades.",
                        
                        // Option 2 from PDF
                        "Consider software upgrades as the armor of your device; if you don't do them on a regular " +
                        "basis, cracks will form, and you'll be at risk of cyberattacks. Hackers are always looking " +
                        "for flaws in out-of-date software so they may install malware, steal data, or take over networks. " +
                        "Updates fix these flaws, strengthening your armor before combat like a blacksmith.\n\n" +
                        "But security isn't the only perk. Updates also:\n" +
                        "- Boost performance: Improve speed, add features, and fix errors to increase performance.\n" +
                        "- Assure compatibility: Maintain the seamless operation of apps on various devices and software.\n" +
                        "- Avoid scams: You may be tricked into installing malware by fake update pop-ups. Update via " +
                        "official settings only—never at random website prompts.",
                        
                        // Option 3 from PDF
                        "Software upgrades are essential for cybersecurity, not just best practice. They are required by " +
                        "institutions such as the University of Idaho because unpatched software is a major point of entry " +
                        "for cybercriminals. This is why updates are important:\n\n" +
                        "1. Security Patches = Risk Reduction\n" +
                        "As vulnerabilities are found, developers address them. Delaying updates exposes systems to:\n" +
                        "- Network attacks\n" +
                        "- Ransomware\n" +
                        "- Data breaches\n\n" +
                        "2. Compliance Requirements\n" +
                        "Patches must be implemented within 30 days, for example, and many institutions enforce update " +
                        "policies. Until they are upgraded, non-compliant devices risk losing their network connectivity.\n\n" +
                        "3. Avoiding Fake Update Scams\n" +
                        "To disseminate malware, cybercriminals imitate legitimate update notices. Red flags include:\n" +
                        "- Strange download links\n" +
                        "- Poor grammar\n" +
                        "- Pressure to take action right away"
                    },
                    FollowUps = new[] { "schedule", "verify", "importance" },
                    FollowUpResponses = new Dictionary<string, string[]>
                    {
                        ["schedule"] = new[]
                        {
                            "Schedule updates during low-usage times, but don't delay critical security patches.",
                            "For businesses, test major updates in a controlled environment before deploying.",
                            "Set devices to automatically install security updates while letting you approve feature updates."
                        },
                        ["verify"] = new[]
                        {
                            "Only download updates from official sources. Fake update pop-ups can install malware.",
                            "Check vendor websites directly if you're unsure about an update's legitimacy.",
                            "Verify update authenticity by checking digital signatures or hashes when available."
                        },
                        ["importance"] = new[]
                        {
                            "The WannaCry ransomware attack exploited systems that hadn't installed available Windows updates.",
                            "Many compliance standards require updates within 30 days of release for security purposes.",
                            "Unpatched software accounts for over 60% of successful cyber attacks according to recent studies."
                        }
                    }
                },

                // Phishing Awareness
                new responseB
                {
                    Triggers = new[] { "phishing", "scams", "4", "emails" },
                    Title = "Phishing Awareness",
                    RandomResponses = new[]
                    {
                        // Original response
                        "Phishing scams have grown more complex and frequently imitate real emails, " +
                        "messages, or phone calls. Any communication that requests personal information, " +
                        "demands quick action, or looks too good to be true should be avoided. Before " +
                        "opening attachments or accessing links, be sure the sender is legitimate, and " +
                        "notify your IT department of any questionable correspondence.",
                        
                        // Option 2 from PDF
                        "Consider a professional scammer who poses as a tech support representative, bank teller, or even a " +
                        "coworker in order to fool you into giving them your wallet. Phishing operates similarly, whereby " +
                        "fraudsters impersonate reliable organizations (such as Microsoft, Amazon, or your bank) to obtain " +
                        "credit card information, passwords, or even take over your computer.\n\n" +
                        "How the Scam Works:\n" +
                        "1. The bait is an urgent SMS or email that says, \"Your account has been locked! To repair it, click here.\"\n" +
                        "2. The hook is that the link leads to a phony login page that appears authentic.\n" +
                        "3. The Catch: The hacker gains access to your accounts as soon as you input your password.\n\n" +
                        "Why It's So Dangerous:\n" +
                        "- AI increases the fear of scams Phishing emails now resemble your boss's writing style and contain " +
                        "flawless language and personal information.\n" +
                        "- A phishing link can transmit malware, lock company files (ransomware), or drain bank accounts with " +
                        "just one click.\n" +
                        "- Hackers send thousands of emails to everyone in the hopes that a few may fall for it.",
                        
                        // Option 3 from PDF
                        "Phishing is a type of cyberattack in which hackers pose as trustworthy organizations (banks, employers, " +
                        "IT businesses) in order to trick victims into downloading malware or disclosing personal information. " +
                        "It circumvents technical defenses by making use of human psychology, specifically trust, anxiety, and urgency.\n\n" +
                        "Key Tactics:\n" +
                        "- Spoofed Communication: Phishing emails and messages imitate legitimate companies, such as Microsoft and PayPal.\n" +
                        "- Malicious Links & Attachments: These can install malware or reroute users to fake websites.\n" +
                        "- \"Update now or lose access!\" is an example of a social engineering message that demands action.\n\n" +
                        "How to Spot & Stop Phishing:\n" +
                        "- Verify the sender addresses to see if they are associated with @amazon.com or @amaz0n-support.ru.\n" +
                        "- Hover before clicking: To view the actual URL on a desktop, move your cursor over links.\n" +
                        "- Avoid clicking in a panic. Urgency is used by phishing (\"Your account will be deleted!\");\n" +
                        "- Employ multi-factor authentication (MFA) to prevent hackers from logging in without your phone, even if " +
                        "they manage to steal your password."
                    },
                    FollowUps = new[] { "identify", "report", "protect" },
                    FollowUpResponses = new Dictionary<string, string[]>
                    {
                        ["identify"] = new[]
                        {
                            "Common red flags: Generic greetings, poor grammar, mismatched sender addresses, and requests for sensitive data.",
                            "Legitimate companies won't ask for passwords or payment info via email. When in doubt, contact them directly.",
                            "Look for subtle misspellings in domain names (e.g., 'amaz0n.com' instead of 'amazon.com')."
                        },
                        ["report"] = new[]
                        {
                            "Forward phishing emails to your IT department and report@phishing.gov. Don't click any links in the message.",
                            "Take screenshots of phishing attempts before deleting them in case you need to report them later.",
                            "Many email providers have 'Report Phishing' buttons that help train their spam filters."
                        },
                        ["protect"] = new[]
                        {
                            "Keep software updated to patch vulnerabilities that phishers exploit in their attacks.",
                            "Use email filters and enable spam protection to reduce phishing attempts reaching your inbox.",
                            "Enable multi-factor authentication everywhere possible to reduce the impact of successful phishing."
                        }
                    }
                },

                // Safe Browsing
                new responseB
                {
                    Triggers = new[] { "safe browsing", "browsing", "5", "internet" },
                    Title = "Safe Browsing",
                    RandomResponses = new[]
                    {
                        // Original response
                        "Use caution when downloading files or accessing websites. Use trustworthy " +
                        "sources, stay away from dubious links or pop-ups, and think about installing " +
                        "security-focused browser extensions. When connecting to unprotected networks, " +
                        "use a VPN to encrypt your internet traffic because public Wi-Fi networks " +
                        "present unique threats.",
                        
                        // Option 2 from PDF
                        "Consider safe browsing to be similar to developing internet street smarts. Safe browsing " +
                        "teaches you how to use the internet without stumbling into cybercriminals' traps, much " +
                        "like you wouldn't give your wallet to a stranger or stroll down a dark alley at night.\n\n" +
                        "Why It Matters:\n" +
                        "- Although socializing, working, and banking all depend on the internet, hackers use it " +
                        "as a playground.\n" +
                        "- There are threats everywhere: phishing emails, malicious downloads, fake " +
                        "websites, and even \"harmless\" cookies can steal your data or spy on you.\n\n" +
                        "Your Safe Browsing Toolkit:\n" +
                        "- Your Padlock = HTTPS A padlock icon and \"https://\" should always be visible in your " +
                        "browser bar before entering credit card numbers or passwords.\n" +
                        "- Prior to clicking, consider your options. Untrustworthy links in pop-ups or emails? " +
                        "Avoid falling for the trick. To view the actual destination, hover over links.\n" +
                        "- All software should be updated since outdated software is like an opened door. To " +
                        "prevent new dangers, keep your operating system, browser, and antivirus software patched.\n" +
                        "- Antivirus = Your Personal Protector Although it's not infallible, it's an essential " +
                        "backup to detect spyware that you might unintentionally welcome in.",
                        
                        // Option 3 from PDF
                        "The user-facing aspect of cybersecurity is safe browsing, which consists of a collection of " +
                        "practices and resources that reduce vulnerability to online dangers such as malware, data " +
                        "theft, and scams. Networks are protected by firewalls and IT standards, but human " +
                        "behaviour is frequently the weakest link.\n\n" +
                        "Because fraudsters frequently construct harmful sites that imitate legal ones, being " +
                        "vigilant about websites is the first step towards safe browsing. Modern browsers display " +
                        "padlock images for websites that support HTTPS, ensuring secure data transmission. " +
                        "Additionally, users should be on the lookout for typos, bad design, and misleading claims.\n\n" +
                        "Because of phishing, a prevalent cyberthreat, email skepticism is essential. Attackers craft " +
                        "persuasive communications that compel users to open attachments or click links without " +
                        "question. Verifying sender addresses, evaluating links, and avoiding unexpected file " +
                        "downloads are all part of safe browsing.\n\n" +
                        "In the end, safe browsing helps to close the gap between everyday behaviour and cybersecurity " +
                        "theory. It enables people to confidently traverse the digital world by converting intangible " +
                        "hazards into preventative measures. These guidelines provide a crucial foundation for security " +
                        "in a connected world, whether one is using them to check one's bank account, shop online, or " +
                        "just browse social media. People and organisations can significantly lower their exposure to " +
                        "the constantly changing range of online risks by making safe practices second nature."
                    },
                    FollowUps = new[] { "https", "vpn", "extensions" },
                    FollowUpResponses = new Dictionary<string, string[]>
                    {
                        ["https"] = new[]
                        {
                            "HTTPS encrypts data between your browser and the website, preventing eavesdropping on your activities.",
                            "Modern browsers mark HTTP sites as 'Not Secure' - avoid entering any sensitive info on these pages.",
                            "Look for the padlock icon and 'https://' in your browser bar before entering sensitive information."
                        },
                        ["vpn"] = new[]
                        {
                            "VPNs encrypt all your internet traffic, especially important on public networks where others might be snooping.",
                            "Choose reputable VPN providers - free VPNs may sell your data or contain malware.",
                            "VPNs hide your real IP address and location, providing additional privacy benefits."
                        },
                        ["extensions"] = new[]
                        {
                            "Extensions like uBlock Origin, HTTPS Everywhere, and Privacy Badger can significantly improve browsing security.",
                            "Only install browser extensions from official stores, and review permissions carefully before installing.",
                            "Some security extensions can block malicious scripts, trackers, and fingerprinting attempts."
                        }
                    }
                }
            };
        }
    }
}