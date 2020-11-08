#include "DefaultApi.h"

using namespace org::openapitools::client::api;

int main(int argc, char* argv[])
{
    std::shared_ptr<ApiClient> apiClient(new ApiClient);
    std::shared_ptr<ApiConfiguration> apiConfig(new ApiConfiguration);

    apiConfig->setBaseUrl(utility::conversions::to_string_t("http://localhost:8080/"));
    apiClient->setConfiguration(apiConfig);

    DefaultApi api(apiClient);

    try
    {
        pplx::task<std::shared_ptr<HttpContent>> request = api.getBackBinaryData();
        std::cerr << "*** BUG ***" << std::endl << std::flush;
        std::cerr << "The next line will cause a segmentation fault (you won't see the error because it's run in docker)." << std::endl << std::flush;
        request.wait();
        std::cerr << "If the docker won't show this line, the previous one crashed." << std::endl << std::flush;
        std::shared_ptr<HttpContent> result = request.get();
    }
    catch(const ApiException& ex)
    {
        std::cerr << ex.what() << std::endl << std::flush;
        return 1;
    }
    catch(const std::exception &ex)
    {
        std::cerr << ex.what() << std::endl << std::flush;
        return 1;
    }
    return 0;
}
