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
        /// This API is used to create a media package channel.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaPackageChannelRequest"/></param>
        /// <returns><see cref="CreateMediaPackageChannelResponse"/></returns>
        public async Task<CreateMediaPackageChannelResponse> CreateMediaPackageChannel(CreateMediaPackageChannelRequest req)
        {
             JsonResponseModel<CreateMediaPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a media package channel.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaPackageChannelRequest"/></param>
        /// <returns><see cref="CreateMediaPackageChannelResponse"/></returns>
        public CreateMediaPackageChannelResponse CreateMediaPackageChannelSync(CreateMediaPackageChannelRequest req)
        {
             JsonResponseModel<CreateMediaPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an endpoint of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="CreateMediaPackageChannelEndpointResponse"/></returns>
        public async Task<CreateMediaPackageChannelEndpointResponse> CreateMediaPackageChannelEndpoint(CreateMediaPackageChannelEndpointRequest req)
        {
             JsonResponseModel<CreateMediaPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create an endpoint of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="CreateMediaPackageChannelEndpointResponse"/></returns>
        public CreateMediaPackageChannelEndpointResponse CreateMediaPackageChannelEndpointSync(CreateMediaPackageChannelEndpointRequest req)
        {
             JsonResponseModel<CreateMediaPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete endpoints from a media package channel in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaPackageChannelEndpointsRequest"/></param>
        /// <returns><see cref="DeleteMediaPackageChannelEndpointsResponse"/></returns>
        public async Task<DeleteMediaPackageChannelEndpointsResponse> DeleteMediaPackageChannelEndpoints(DeleteMediaPackageChannelEndpointsRequest req)
        {
             JsonResponseModel<DeleteMediaPackageChannelEndpointsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMediaPackageChannelEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaPackageChannelEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete endpoints from a media package channel in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaPackageChannelEndpointsRequest"/></param>
        /// <returns><see cref="DeleteMediaPackageChannelEndpointsResponse"/></returns>
        public DeleteMediaPackageChannelEndpointsResponse DeleteMediaPackageChannelEndpointsSync(DeleteMediaPackageChannelEndpointsRequest req)
        {
             JsonResponseModel<DeleteMediaPackageChannelEndpointsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMediaPackageChannelEndpoints");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaPackageChannelEndpointsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete media package channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaPackageChannelsRequest"/></param>
        /// <returns><see cref="DeleteMediaPackageChannelsResponse"/></returns>
        public async Task<DeleteMediaPackageChannelsResponse> DeleteMediaPackageChannels(DeleteMediaPackageChannelsRequest req)
        {
             JsonResponseModel<DeleteMediaPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMediaPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete media package channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaPackageChannelsRequest"/></param>
        /// <returns><see cref="DeleteMediaPackageChannelsResponse"/></returns>
        public DeleteMediaPackageChannelsResponse DeleteMediaPackageChannelsSync(DeleteMediaPackageChannelsRequest req)
        {
             JsonResponseModel<DeleteMediaPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMediaPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPackageChannelRequest"/></param>
        /// <returns><see cref="DescribeMediaPackageChannelResponse"/></returns>
        public async Task<DescribeMediaPackageChannelResponse> DescribeMediaPackageChannel(DescribeMediaPackageChannelRequest req)
        {
             JsonResponseModel<DescribeMediaPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPackageChannelRequest"/></param>
        /// <returns><see cref="DescribeMediaPackageChannelResponse"/></returns>
        public DescribeMediaPackageChannelResponse DescribeMediaPackageChannelSync(DescribeMediaPackageChannelRequest req)
        {
             JsonResponseModel<DescribeMediaPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information list of media package channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPackageChannelsRequest"/></param>
        /// <returns><see cref="DescribeMediaPackageChannelsResponse"/></returns>
        public async Task<DescribeMediaPackageChannelsResponse> DescribeMediaPackageChannels(DescribeMediaPackageChannelsRequest req)
        {
             JsonResponseModel<DescribeMediaPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the information list of media package channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaPackageChannelsRequest"/></param>
        /// <returns><see cref="DescribeMediaPackageChannelsResponse"/></returns>
        public DescribeMediaPackageChannelsResponse DescribeMediaPackageChannelsSync(DescribeMediaPackageChannelsRequest req)
        {
             JsonResponseModel<DescribeMediaPackageChannelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaPackageChannels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaPackageChannelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaPackageChannelRequest"/></param>
        /// <returns><see cref="ModifyMediaPackageChannelResponse"/></returns>
        public async Task<ModifyMediaPackageChannelResponse> ModifyMediaPackageChannel(ModifyMediaPackageChannelRequest req)
        {
             JsonResponseModel<ModifyMediaPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaPackageChannelRequest"/></param>
        /// <returns><see cref="ModifyMediaPackageChannelResponse"/></returns>
        public ModifyMediaPackageChannelResponse ModifyMediaPackageChannelSync(ModifyMediaPackageChannelRequest req)
        {
             JsonResponseModel<ModifyMediaPackageChannelResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaPackageChannel");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaPackageChannelResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an endpoint of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="ModifyMediaPackageChannelEndpointResponse"/></returns>
        public async Task<ModifyMediaPackageChannelEndpointResponse> ModifyMediaPackageChannelEndpoint(ModifyMediaPackageChannelEndpointRequest req)
        {
             JsonResponseModel<ModifyMediaPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an endpoint of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="ModifyMediaPackageChannelEndpointResponse"/></returns>
        public ModifyMediaPackageChannelEndpointResponse ModifyMediaPackageChannelEndpointSync(ModifyMediaPackageChannelEndpointRequest req)
        {
             JsonResponseModel<ModifyMediaPackageChannelEndpointResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaPackageChannelEndpoint");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaPackageChannelEndpointResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the input authentication information of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaPackageChannelInputAuthInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaPackageChannelInputAuthInfoResponse"/></returns>
        public async Task<ModifyMediaPackageChannelInputAuthInfoResponse> ModifyMediaPackageChannelInputAuthInfo(ModifyMediaPackageChannelInputAuthInfoRequest req)
        {
             JsonResponseModel<ModifyMediaPackageChannelInputAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaPackageChannelInputAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaPackageChannelInputAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the input authentication information of a media package channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaPackageChannelInputAuthInfoRequest"/></param>
        /// <returns><see cref="ModifyMediaPackageChannelInputAuthInfoResponse"/></returns>
        public ModifyMediaPackageChannelInputAuthInfoResponse ModifyMediaPackageChannelInputAuthInfoSync(ModifyMediaPackageChannelInputAuthInfoRequest req)
        {
             JsonResponseModel<ModifyMediaPackageChannelInputAuthInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaPackageChannelInputAuthInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaPackageChannelInputAuthInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
