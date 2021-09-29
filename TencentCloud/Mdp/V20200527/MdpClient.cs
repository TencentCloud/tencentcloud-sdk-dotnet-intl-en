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

namespace TencentCloud.Mdp.V20200527
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mdp.V20200527.Models;

   public class MdpClient : AbstractClient{

       private const string endpoint = "mdp.tencentcloudapi.com";
       private const string version = "2020-05-27";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MdpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to bind an LVB domain name to a channel.
        /// </summary>
        /// <param name="req"><see cref="BindNewLVBDomainWithChannelRequest"/></param>
        /// <returns><see cref="BindNewLVBDomainWithChannelResponse"/></returns>
        public async Task<BindNewLVBDomainWithChannelResponse> BindNewLVBDomainWithChannel(BindNewLVBDomainWithChannelRequest req)
        {
             JsonResponseModel<BindNewLVBDomainWithChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindNewLVBDomainWithChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindNewLVBDomainWithChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind an LVB domain name to a channel.
        /// </summary>
        /// <param name="req"><see cref="BindNewLVBDomainWithChannelRequest"/></param>
        /// <returns><see cref="BindNewLVBDomainWithChannelResponse"/></returns>
        public BindNewLVBDomainWithChannelResponse BindNewLVBDomainWithChannelSync(BindNewLVBDomainWithChannelRequest req)
        {
             JsonResponseModel<BindNewLVBDomainWithChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindNewLVBDomainWithChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindNewLVBDomainWithChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelResponse"/></returns>
        public async Task<CreateStreamPackageChannelResponse> CreateStreamPackageChannel(CreateStreamPackageChannelRequest req)
        {
             JsonResponseModel<CreateStreamPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelResponse"/></returns>
        public CreateStreamPackageChannelResponse CreateStreamPackageChannelSync(CreateStreamPackageChannelRequest req)
        {
             JsonResponseModel<CreateStreamPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an endpoint on a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelEndpointResponse"/></returns>
        public async Task<CreateStreamPackageChannelEndpointResponse> CreateStreamPackageChannelEndpoint(CreateStreamPackageChannelEndpointRequest req)
        {
             JsonResponseModel<CreateStreamPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStreamPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an endpoint on a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelEndpointResponse"/></returns>
        public CreateStreamPackageChannelEndpointResponse CreateStreamPackageChannelEndpointSync(CreateStreamPackageChannelEndpointRequest req)
        {
             JsonResponseModel<CreateStreamPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStreamPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStreamPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete endpoints from a StreamPackage channel in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelEndpointsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelEndpointsResponse"/></returns>
        public async Task<DeleteStreamPackageChannelEndpointsResponse> DeleteStreamPackageChannelEndpoints(DeleteStreamPackageChannelEndpointsRequest req)
        {
             JsonResponseModel<DeleteStreamPackageChannelEndpointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamPackageChannelEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamPackageChannelEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete endpoints from a StreamPackage channel in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelEndpointsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelEndpointsResponse"/></returns>
        public DeleteStreamPackageChannelEndpointsResponse DeleteStreamPackageChannelEndpointsSync(DeleteStreamPackageChannelEndpointsRequest req)
        {
             JsonResponseModel<DeleteStreamPackageChannelEndpointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamPackageChannelEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamPackageChannelEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete StreamPackage channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelsResponse"/></returns>
        public async Task<DeleteStreamPackageChannelsResponse> DeleteStreamPackageChannels(DeleteStreamPackageChannelsRequest req)
        {
             JsonResponseModel<DeleteStreamPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStreamPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete StreamPackage channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelsResponse"/></returns>
        public DeleteStreamPackageChannelsResponse DeleteStreamPackageChannelsSync(DeleteStreamPackageChannelsRequest req)
        {
             JsonResponseModel<DeleteStreamPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStreamPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStreamPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelResponse"/></returns>
        public async Task<DescribeStreamPackageChannelResponse> DescribeStreamPackageChannel(DescribeStreamPackageChannelRequest req)
        {
             JsonResponseModel<DescribeStreamPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelResponse"/></returns>
        public DescribeStreamPackageChannelResponse DescribeStreamPackageChannelSync(DescribeStreamPackageChannelRequest req)
        {
             JsonResponseModel<DescribeStreamPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of multiple StreamPackage channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelsResponse"/></returns>
        public async Task<DescribeStreamPackageChannelsResponse> DescribeStreamPackageChannels(DescribeStreamPackageChannelsRequest req)
        {
             JsonResponseModel<DescribeStreamPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStreamPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of multiple StreamPackage channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelsResponse"/></returns>
        public DescribeStreamPackageChannelsResponse DescribeStreamPackageChannelsSync(DescribeStreamPackageChannelsRequest req)
        {
             JsonResponseModel<DescribeStreamPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStreamPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStreamPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelResponse"/></returns>
        public async Task<ModifyStreamPackageChannelResponse> ModifyStreamPackageChannel(ModifyStreamPackageChannelRequest req)
        {
             JsonResponseModel<ModifyStreamPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelResponse"/></returns>
        public ModifyStreamPackageChannelResponse ModifyStreamPackageChannelSync(ModifyStreamPackageChannelRequest req)
        {
             JsonResponseModel<ModifyStreamPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an endpoint of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelEndpointResponse"/></returns>
        public async Task<ModifyStreamPackageChannelEndpointResponse> ModifyStreamPackageChannelEndpoint(ModifyStreamPackageChannelEndpointRequest req)
        {
             JsonResponseModel<ModifyStreamPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an endpoint of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelEndpointResponse"/></returns>
        public ModifyStreamPackageChannelEndpointResponse ModifyStreamPackageChannelEndpointSync(ModifyStreamPackageChannelEndpointRequest req)
        {
             JsonResponseModel<ModifyStreamPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the input authentication information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelInputAuthInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelInputAuthInfoResponse"/></returns>
        public async Task<ModifyStreamPackageChannelInputAuthInfoResponse> ModifyStreamPackageChannelInputAuthInfo(ModifyStreamPackageChannelInputAuthInfoRequest req)
        {
             JsonResponseModel<ModifyStreamPackageChannelInputAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyStreamPackageChannelInputAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamPackageChannelInputAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the input authentication information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelInputAuthInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelInputAuthInfoResponse"/></returns>
        public ModifyStreamPackageChannelInputAuthInfoResponse ModifyStreamPackageChannelInputAuthInfoSync(ModifyStreamPackageChannelInputAuthInfoRequest req)
        {
             JsonResponseModel<ModifyStreamPackageChannelInputAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyStreamPackageChannelInputAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyStreamPackageChannelInputAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
