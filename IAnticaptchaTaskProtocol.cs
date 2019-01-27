using AntiCaptcha.NetCore.ApiResponse;
using Newtonsoft.Json.Linq;

namespace AntiCaptcha
{
    public interface IAnticaptchaTaskProtocol
    {
        JObject GetPostData();
        TaskResultResponse.SolutionData GetTaskSolution();
    }
}