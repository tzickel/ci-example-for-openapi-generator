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
        pplx::task<std::shared_ptr<AnObjectWithDouble>> request = api.getAnObjectWithNumbers();
        request.wait();
        std::shared_ptr<AnObjectWithDouble> result = request.get();
        std::cerr << "*** BUG ***" << std::endl << std::flush;
        std::cerr << "The result should be {\"num1\":1,\"num2\":1} but is:" << std::endl << std::flush;
        std::cerr << result->toJson().serialize().c_str() << std::endl << std::flush;
        // TODO turn this to assert
        return 1;
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
