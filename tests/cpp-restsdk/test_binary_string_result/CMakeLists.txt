cmake_minimum_required(VERSION 3.13)

project(client)

add_subdirectory(autogen)

add_executable(client client.cpp)

target_link_libraries(client
  CppRestOpenAPIClient)

target_include_directories(client PUBLIC
  "${PROJECT_SOURCE_DIR}/autogen/api"
  "${PROJECT_SOURCE_DIR}/autogen/")
