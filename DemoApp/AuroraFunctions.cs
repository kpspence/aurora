using System.Net.Mime;
using Atl;
using Avl;
using Exception = System.Exception;

namespace DemoApp
{
    public static class AuroraFunctions 
    {
        public static void ReadOCR(float x, float y, float w, float h, int chrHeight)
        {
            var chrReadId = new ReadCharactersModelId(
                null,
                Avl.OcrPretrainedModel.Extended,
                Avl.DeviceKind.CPU,
                0);

            var allowedCharacters = new Optional<string>("A-Z,0-9");

            List<Region> regions = new List<Region>();
            List<OcrResult> ocrResult = new List<OcrResult>();
            List<List<OcrCandidate>> ocrCandidate = new List<List<OcrCandidate>>();
            List<Region> ocrRegions = new List<Region>();
            Diagnostic<Image>? diag = new();

            Image img = new();
            
            Avl.Invoke.LoadImage("test.png",true, img);

            try
            {
                Avl.DLInvoke.DL_ReadCharacters(img,
                    new Optional<Rectangle2D>(new Rectangle2D(new Point2D(x, y), 0.0f, w, h)),
                    null,
                    chrReadId,
                    chrHeight,
                    1.0f,
                    0.0f,
                    allowedCharacters,
                    .5f, //min score
                    Polarity.Any,
                    0.0f,
                    true,
                    false,
                    ocrResult,
                    ocrCandidate,
                    ocrRegions,
                    null,
                    diag);

                Console.WriteLine($"Characters decoded: {ocrResult.Count}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
