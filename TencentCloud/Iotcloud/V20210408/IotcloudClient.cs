/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Iotcloud.V20210408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iotcloud.V20210408.Models;

   public class IotcloudClient : AbstractClient{

       private const string endpoint = "iotcloud.tencentcloudapi.com";
       private const string version = "2021-04-08";
       private const string sdkVersion = "SDK_NET_3.0.965";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IotcloudClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IotcloudClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create an IoT Hub device. 
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public Task<CreateDeviceResponse> CreateDevice(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice");
        }

        /// <summary>
        /// This API is used to create an IoT Hub device. 
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceRequest"/></param>
        /// <returns><see cref="CreateDeviceResponse"/></returns>
        public CreateDeviceResponse CreateDeviceSync(CreateDeviceRequest req)
        {
            return InternalRequestAsync<CreateDeviceResponse>(req, "CreateDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public Task<CreatePrivateCAResponse> CreatePrivateCA(CreatePrivateCARequest req)
        {
            return InternalRequestAsync<CreatePrivateCAResponse>(req, "CreatePrivateCA");
        }

        /// <summary>
        /// This API is used to create a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="CreatePrivateCARequest"/></param>
        /// <returns><see cref="CreatePrivateCAResponse"/></returns>
        public CreatePrivateCAResponse CreatePrivateCASync(CreatePrivateCARequest req)
        {
            return InternalRequestAsync<CreatePrivateCAResponse>(req, "CreatePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a new IoT communication product. 
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public Task<CreateProductResponse> CreateProduct(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct");
        }

        /// <summary>
        /// This API is used to create a new IoT communication product. 
        /// </summary>
        /// <param name="req"><see cref="CreateProductRequest"/></param>
        /// <returns><see cref="CreateProductResponse"/></returns>
        public CreateProductResponse CreateProductSync(CreateProductRequest req)
        {
            return InternalRequestAsync<CreateProductResponse>(req, "CreateProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an IoT Hub device. 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public Task<DeleteDeviceResponse> DeleteDevice(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice");
        }

        /// <summary>
        /// This API is used to delete an IoT Hub device. 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceRequest"/></param>
        /// <returns><see cref="DeleteDeviceResponse"/></returns>
        public DeleteDeviceResponse DeleteDeviceSync(DeleteDeviceRequest req)
        {
            return InternalRequestAsync<DeleteDeviceResponse>(req, "DeleteDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a device shadow. 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceShadowRequest"/></param>
        /// <returns><see cref="DeleteDeviceShadowResponse"/></returns>
        public Task<DeleteDeviceShadowResponse> DeleteDeviceShadow(DeleteDeviceShadowRequest req)
        {
            return InternalRequestAsync<DeleteDeviceShadowResponse>(req, "DeleteDeviceShadow");
        }

        /// <summary>
        /// This API is used to delete a device shadow. 
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceShadowRequest"/></param>
        /// <returns><see cref="DeleteDeviceShadowResponse"/></returns>
        public DeleteDeviceShadowResponse DeleteDeviceShadowSync(DeleteDeviceShadowRequest req)
        {
            return InternalRequestAsync<DeleteDeviceShadowResponse>(req, "DeleteDeviceShadow")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public Task<DeletePrivateCAResponse> DeletePrivateCA(DeletePrivateCARequest req)
        {
            return InternalRequestAsync<DeletePrivateCAResponse>(req, "DeletePrivateCA");
        }

        /// <summary>
        /// This API is used to delete a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="DeletePrivateCARequest"/></param>
        /// <returns><see cref="DeletePrivateCAResponse"/></returns>
        public DeletePrivateCAResponse DeletePrivateCASync(DeletePrivateCARequest req)
        {
            return InternalRequestAsync<DeletePrivateCAResponse>(req, "DeletePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete an IoT Hub product.
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct");
        }

        /// <summary>
        /// This API is used to delete an IoT Hub product.
        /// </summary>
        /// <param name="req"><see cref="DeleteProductRequest"/></param>
        /// <returns><see cref="DeleteProductResponse"/></returns>
        public DeleteProductResponse DeleteProductSync(DeleteProductRequest req)
        {
            return InternalRequestAsync<DeleteProductResponse>(req, "DeleteProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query device details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public Task<DescribeDeviceResponse> DescribeDevice(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice");
        }

        /// <summary>
        /// This API is used to query device details.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceRequest"/></param>
        /// <returns><see cref="DescribeDeviceResponse"/></returns>
        public DescribeDeviceResponse DescribeDeviceSync(DescribeDeviceRequest req)
        {
            return InternalRequestAsync<DescribeDeviceResponse>(req, "DescribeDevice")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of IoT Hub devices. 
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices");
        }

        /// <summary>
        /// This API is used to get the list of IoT Hub devices. 
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
            return InternalRequestAsync<DescribeDevicesResponse>(req, "DescribeDevices")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query private CA certificate details.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public Task<DescribePrivateCAResponse> DescribePrivateCA(DescribePrivateCARequest req)
        {
            return InternalRequestAsync<DescribePrivateCAResponse>(req, "DescribePrivateCA");
        }

        /// <summary>
        /// This API is used to query private CA certificate details.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCARequest"/></param>
        /// <returns><see cref="DescribePrivateCAResponse"/></returns>
        public DescribePrivateCAResponse DescribePrivateCASync(DescribePrivateCARequest req)
        {
            return InternalRequestAsync<DescribePrivateCAResponse>(req, "DescribePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the products bound to a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public Task<DescribePrivateCABindedProductsResponse> DescribePrivateCABindedProducts(DescribePrivateCABindedProductsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCABindedProductsResponse>(req, "DescribePrivateCABindedProducts");
        }

        /// <summary>
        /// This API is used to query the products bound to a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCABindedProductsRequest"/></param>
        /// <returns><see cref="DescribePrivateCABindedProductsResponse"/></returns>
        public DescribePrivateCABindedProductsResponse DescribePrivateCABindedProductsSync(DescribePrivateCABindedProductsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCABindedProductsResponse>(req, "DescribePrivateCABindedProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of private CA certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public Task<DescribePrivateCAsResponse> DescribePrivateCAs(DescribePrivateCAsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCAsResponse>(req, "DescribePrivateCAs");
        }

        /// <summary>
        /// This API is used to get the list of private CA certificates.
        /// </summary>
        /// <param name="req"><see cref="DescribePrivateCAsRequest"/></param>
        /// <returns><see cref="DescribePrivateCAsResponse"/></returns>
        public DescribePrivateCAsResponse DescribePrivateCAsSync(DescribePrivateCAsRequest req)
        {
            return InternalRequestAsync<DescribePrivateCAsResponse>(req, "DescribePrivateCAs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query product details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public Task<DescribeProductResponse> DescribeProduct(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct");
        }

        /// <summary>
        /// This API is used to query product details.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductRequest"/></param>
        /// <returns><see cref="DescribeProductResponse"/></returns>
        public DescribeProductResponse DescribeProductSync(DescribeProductRequest req)
        {
            return InternalRequestAsync<DescribeProductResponse>(req, "DescribeProduct")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CA certificates bound to a product.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public Task<DescribeProductCAResponse> DescribeProductCA(DescribeProductCARequest req)
        {
            return InternalRequestAsync<DescribeProductCAResponse>(req, "DescribeProductCA");
        }

        /// <summary>
        /// This API is used to query the CA certificates bound to a product.
        /// </summary>
        /// <param name="req"><see cref="DescribeProductCARequest"/></param>
        /// <returns><see cref="DescribeProductCAResponse"/></returns>
        public DescribeProductCAResponse DescribeProductCASync(DescribeProductCARequest req)
        {
            return InternalRequestAsync<DescribeProductCAResponse>(req, "DescribeProductCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the product list. 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public Task<DescribeProductsResponse> DescribeProducts(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts");
        }

        /// <summary>
        /// This API is used to obtain the product list. 
        /// </summary>
        /// <param name="req"><see cref="DescribeProductsRequest"/></param>
        /// <returns><see cref="DescribeProductsResponse"/></returns>
        public DescribeProductsResponse DescribeProductsSync(DescribeProductsRequest req)
        {
            return InternalRequestAsync<DescribeProductsResponse>(req, "DescribeProducts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable multiple products at a time.
        /// </summary>
        /// <param name="req"><see cref="SetProductsForbiddenStatusRequest"/></param>
        /// <returns><see cref="SetProductsForbiddenStatusResponse"/></returns>
        public Task<SetProductsForbiddenStatusResponse> SetProductsForbiddenStatus(SetProductsForbiddenStatusRequest req)
        {
            return InternalRequestAsync<SetProductsForbiddenStatusResponse>(req, "SetProductsForbiddenStatus");
        }

        /// <summary>
        /// This API is used to enable or disable multiple products at a time.
        /// </summary>
        /// <param name="req"><see cref="SetProductsForbiddenStatusRequest"/></param>
        /// <returns><see cref="SetProductsForbiddenStatusResponse"/></returns>
        public SetProductsForbiddenStatusResponse SetProductsForbiddenStatusSync(SetProductsForbiddenStatusRequest req)
        {
            return InternalRequestAsync<SetProductsForbiddenStatusResponse>(req, "SetProductsForbiddenStatus")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set the device log level.  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public Task<UpdateDeviceLogLevelResponse> UpdateDeviceLogLevel(UpdateDeviceLogLevelRequest req)
        {
            return InternalRequestAsync<UpdateDeviceLogLevelResponse>(req, "UpdateDeviceLogLevel");
        }

        /// <summary>
        /// This API is used to set the device log level.  
        /// </summary>
        /// <param name="req"><see cref="UpdateDeviceLogLevelRequest"/></param>
        /// <returns><see cref="UpdateDeviceLogLevelResponse"/></returns>
        public UpdateDeviceLogLevelResponse UpdateDeviceLogLevelSync(UpdateDeviceLogLevelRequest req)
        {
            return InternalRequestAsync<UpdateDeviceLogLevelResponse>(req, "UpdateDeviceLogLevel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable or disable multiple devices. 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public Task<UpdateDevicesEnableStateResponse> UpdateDevicesEnableState(UpdateDevicesEnableStateRequest req)
        {
            return InternalRequestAsync<UpdateDevicesEnableStateResponse>(req, "UpdateDevicesEnableState");
        }

        /// <summary>
        /// This API is used to enable or disable multiple devices. 
        /// </summary>
        /// <param name="req"><see cref="UpdateDevicesEnableStateRequest"/></param>
        /// <returns><see cref="UpdateDevicesEnableStateResponse"/></returns>
        public UpdateDevicesEnableStateResponse UpdateDevicesEnableStateSync(UpdateDevicesEnableStateRequest req)
        {
            return InternalRequestAsync<UpdateDevicesEnableStateResponse>(req, "UpdateDevicesEnableState")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public Task<UpdatePrivateCAResponse> UpdatePrivateCA(UpdatePrivateCARequest req)
        {
            return InternalRequestAsync<UpdatePrivateCAResponse>(req, "UpdatePrivateCA");
        }

        /// <summary>
        /// This API is used to update a private CA certificate.
        /// </summary>
        /// <param name="req"><see cref="UpdatePrivateCARequest"/></param>
        /// <returns><see cref="UpdatePrivateCAResponse"/></returns>
        public UpdatePrivateCAResponse UpdatePrivateCASync(UpdatePrivateCARequest req)
        {
            return InternalRequestAsync<UpdatePrivateCAResponse>(req, "UpdatePrivateCA")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to update the configuration of product dynamic registration. 
        /// </summary>
        /// <param name="req"><see cref="UpdateProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="UpdateProductDynamicRegisterResponse"/></returns>
        public Task<UpdateProductDynamicRegisterResponse> UpdateProductDynamicRegister(UpdateProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<UpdateProductDynamicRegisterResponse>(req, "UpdateProductDynamicRegister");
        }

        /// <summary>
        /// This API is used to update the configuration of product dynamic registration. 
        /// </summary>
        /// <param name="req"><see cref="UpdateProductDynamicRegisterRequest"/></param>
        /// <returns><see cref="UpdateProductDynamicRegisterResponse"/></returns>
        public UpdateProductDynamicRegisterResponse UpdateProductDynamicRegisterSync(UpdateProductDynamicRegisterRequest req)
        {
            return InternalRequestAsync<UpdateProductDynamicRegisterResponse>(req, "UpdateProductDynamicRegister")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
