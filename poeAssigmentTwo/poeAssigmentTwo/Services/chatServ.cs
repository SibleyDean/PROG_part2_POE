using System;
using System.Collections.Generic;
using System.Linq;
using poeAssigmentTwo.Structures;

namespace poeAssigmentTwo.Services
{
    public class ChatServ
    {
        private readonly displayASCII _display;
        private readonly tipsB _tipsB;
        private readonly List<responseB> _responseB;
        private readonly Random _random;

        private responseB? _currentTopic;
        private Dictionary<responseB, int> _topicResponseIndices;
        private HashSet<string> _userInterests;

        private readonly Dictionary<string, string> _sentimentResponses = new()
        {
            { "worried", "It's completely understandable to feel that way. Cybersecurity threats can seem scary, but there are simple steps you can take to protect yourself." },
            { "anxious", "It's completely understandable to feel that way. Cybersecurity threats can seem scary, but there are simple steps you can take to protect yourself." },
            { "scared", "It's completely understandable to feel that way. Cybersecurity threats can seem scary, but there are simple steps you can take to protect yourself." },
            { "frustrated", "I get that this can be overwhelming. Cybersecurity can be complex, but I'm here to break it down for you step by step." },
            { "confused", "I get that this can be overwhelming. Cybersecurity can be complex, but I'm here to break it down for you step by step." },
            { "overwhelmed", "I get that this can be overwhelming. Cybersecurity can be complex, but I'm here to break it down for you step by step." },
            { "curious", "I'm glad you're curious! Understanding cybersecurity is a great way to stay safe in the digital world." },
            { "interested", "I'm glad you're curious! Understanding cybersecurity is a great way to stay safe in the digital world." },
            { "keen", "I'm glad you're curious! Understanding cybersecurity is a great way to stay safe in the digital world." }
        };

        public ChatServ(displayASCII display, tipsB tipsService)
        {
            _display = display;
            _tipsB = tipsService;
            _responseB = _tipsB?.GetCybersecurityTips() ?? new List<responseB>();
            _random = new Random();
            _topicResponseIndices = new Dictionary<responseB, int>();
            _userInterests = new HashSet<string>();

            if (_responseB.Count == 0)
            {
                Console.WriteLine("Warning: No cybersecurity tips loaded!");
            }
        }

        public string GetUserName()
        {
            while (true)
            {
                _display.TypeWrite("Please enter your name: ", 15);
                string? name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name) && name.Length <= 30)
                    return name.Trim();

                _display.TypeWrite("Invalid input. Names must be 1-30 characters:", 10);
            }
        }

        public void ShowMainMenu()
        {
            if (!_responseB.Any())
            {
                _display.TypeWrite("No topics available at the moment.", 10);
                return;
            }

            _display.TypeWrite("\nHere are some common cybersecurity topics I can help with:", 15);
            _display.TypeWrite("You can ask about any of these or type your own question:", 15);

            foreach (var (response, index) in _responseB.Select((r, i) => (r, i)))
            {
                _display.TypeWrite($"{index + 1}. {response.Title}", 10);
            }

            _display.TypeWrite("\nExamples:", 10);
            _display.TypeWrite("- 'Tell me about passwords'", 10);
            _display.TypeWrite("- 'How do I stay safe from phishing?'", 10);
            _display.TypeWrite("- '3' (for software updates)", 10);
            _display.TypeWrite("- Type 'exit' to end our chat", 10);
        }

        public void ProcessUserChoice(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                _display.TypeWrite("Please enter a valid question.", 10);
                return;
            }

            var sanitizedInput = input.Trim().ToLower();

            if (TryCaptureInterest(sanitizedInput)) return;
            if (TryDetectSentiment(sanitizedInput)) return;
            if (TryHandleFollowUp(sanitizedInput)) return;

            responseB? matched = MatchTopic(sanitizedInput);
            if (matched != null)
            {
                ShowTopicWithRotation(matched);
                TryRecallInterest(matched);
                return;
            }

            ShowFallbackMessage();
        }

        private bool TryCaptureInterest(string input)
        {
            if (input.StartsWith("i'm interested in") || input.StartsWith("i am interested in"))
            {
                string interest = input.Replace("i'm interested in", "")
                                       .Replace("i am interested in", "")
                                       .Trim();
                if (!string.IsNullOrEmpty(interest))
                {
                    _userInterests.Add(interest);
                    _display.TypeWrite($"Great! I'll remember that you're interested in {interest}. It's a crucial part of staying safe online.", 10);
                    return true;
                }
            }
            return false;
        }

        private bool TryDetectSentiment(string input)
        {
            foreach (var (keyword, message) in _sentimentResponses)
            {
                if (input.Contains(keyword))
                {
                    _display.TypeWrite(message, 10);
                    return false; // continue processing main input
                }
            }
            return false;
        }

        private bool TryHandleFollowUp(string input)
        {
            if (_currentTopic == null || _currentTopic.FollowUpResponses == null) return false;

            foreach (var key in _currentTopic.FollowUpResponses.Keys)
            {
                if (input.Contains(key.ToLower()))
                {
                    var responses = _currentTopic.FollowUpResponses[key];
                    var reply = responses[_random.Next(responses.Length)];
                    _display.TypeWrite($"\nFollow-up: {reply}", 10);
                    return true;
                }
            }

            return false;
        }

        private responseB? MatchTopic(string input)
        {
            if (int.TryParse(input, out int choice) && choice > 0 && choice <= _responseB.Count)
            {
                return _responseB[choice - 1];
            }

            return _responseB.FirstOrDefault(r =>
                r.Triggers.Any(t => input.Contains(t.ToLower())) ||
                r.Title.ToLower().Contains(input));
        }

        private void ShowTopicWithRotation(responseB topic)
        {
            int index = _topicResponseIndices.ContainsKey(topic)
                        ? (_topicResponseIndices[topic] + 1) % topic.RandomResponses.Length
                        : _random.Next(topic.RandomResponses.Length);

            _topicResponseIndices[topic] = index;
            _currentTopic = topic;

            _display.ShowTopic(topic, index);
        }

        private void TryRecallInterest(responseB topic)
        {
            foreach (var interest in _userInterests)
            {
                if (topic.Triggers.Any(t =>
                    t.ToLower().Contains(interest.ToLower()) ||
                    interest.ToLower().Contains(t.ToLower())))
                {
                    _display.TypeWrite($"\nAs someone interested in {interest}, you might want to pay extra attention to this topic.", 10);
                    break;
                }
            }
        }

        private void ShowFallbackMessage()
        {
            _display.TypeWrite("I'm not sure I understand. Can you try rephrasing?", 10);
        }
    }
}
