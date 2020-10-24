using Microsoft.AspNetCore.Mvc;
using OpenNLP.Tools.Tokenize;

namespace NLP.Controllers
{
    public class TokenizerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Tokenize(string sentence)
        {
            //// Regular tokenizer
            //var modelPath = "path/to/EnglishTok.nbin";
            //var sentence = "- Sorry Mrs. Hudson, I'll skip the tea.";
            //var tokenizer = new EnglishMaximumEntropyTokenizer(modelPath);
            //var tokens = tokenizer.Tokenize(sentence);
            //// tokens = ["-", "Sorry", "Mrs.", "Hudson", ",", "I", "'ll", "skip", "the", "tea", "."]

            // English tokenizer
            EnglishRuleBasedTokenizer tokenizer = new EnglishRuleBasedTokenizer(false);
            //var sentence = "- Sorry Mrs. Hudson, I'll skip the tea.";
            var tokens = tokenizer.Tokenize(sentence);
            // tokens = ["-", "Sorry", "Mrs.", "Hudson", ",", "I", "'ll", "skip", "the", "tea", "."]

            return new JsonResult(tokens);
        }
    }
}
