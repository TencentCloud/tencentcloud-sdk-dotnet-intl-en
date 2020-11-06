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

namespace TencentCloud.Mdc.V20200828
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mdc.V20200828.Models;

   public class MdcClient : AbstractClient{

       private const string endpoint = "mdc.tencentcloudapi.com";
       private const string version = "2020-08-28";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MdcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MdcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to create the configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaConnectFlowRequest"/></param>
        /// <returns><see cref="CreateMediaConnectFlowResponse"/></returns>
        public async Task<CreateMediaConnectFlowResponse> CreateMediaConnectFlow(CreateMediaConnectFlowRequest req)
        {
             JsonResponseModel<CreateMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaConnectFlowRequest"/></param>
        /// <returns><see cref="CreateMediaConnectFlowResponse"/></returns>
        public CreateMediaConnectFlowResponse CreateMediaConnectFlowSync(CreateMediaConnectFlowRequest req)
        {
             JsonResponseModel<CreateMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the output information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaConnectOutputRequest"/></param>
        /// <returns><see cref="CreateMediaConnectOutputResponse"/></returns>
        public async Task<CreateMediaConnectOutputResponse> CreateMediaConnectOutput(CreateMediaConnectOutputRequest req)
        {
             JsonResponseModel<CreateMediaConnectOutputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMediaConnectOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaConnectOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create the output information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="CreateMediaConnectOutputRequest"/></param>
        /// <returns><see cref="CreateMediaConnectOutputResponse"/></returns>
        public CreateMediaConnectOutputResponse CreateMediaConnectOutputSync(CreateMediaConnectOutputRequest req)
        {
             JsonResponseModel<CreateMediaConnectOutputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMediaConnectOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMediaConnectOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaConnectFlowRequest"/></param>
        /// <returns><see cref="DeleteMediaConnectFlowResponse"/></returns>
        public async Task<DeleteMediaConnectFlowResponse> DeleteMediaConnectFlow(DeleteMediaConnectFlowRequest req)
        {
             JsonResponseModel<DeleteMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaConnectFlowRequest"/></param>
        /// <returns><see cref="DeleteMediaConnectFlowResponse"/></returns>
        public DeleteMediaConnectFlowResponse DeleteMediaConnectFlowSync(DeleteMediaConnectFlowRequest req)
        {
             JsonResponseModel<DeleteMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the output configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaConnectOutputRequest"/></param>
        /// <returns><see cref="DeleteMediaConnectOutputResponse"/></returns>
        public async Task<DeleteMediaConnectOutputResponse> DeleteMediaConnectOutput(DeleteMediaConnectOutputRequest req)
        {
             JsonResponseModel<DeleteMediaConnectOutputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteMediaConnectOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaConnectOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the output configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="DeleteMediaConnectOutputRequest"/></param>
        /// <returns><see cref="DeleteMediaConnectOutputResponse"/></returns>
        public DeleteMediaConnectOutputResponse DeleteMediaConnectOutputSync(DeleteMediaConnectOutputRequest req)
        {
             JsonResponseModel<DeleteMediaConnectOutputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteMediaConnectOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteMediaConnectOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaConnectFlowRequest"/></param>
        /// <returns><see cref="DescribeMediaConnectFlowResponse"/></returns>
        public async Task<DescribeMediaConnectFlowResponse> DescribeMediaConnectFlow(DescribeMediaConnectFlowRequest req)
        {
             JsonResponseModel<DescribeMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaConnectFlowRequest"/></param>
        /// <returns><see cref="DescribeMediaConnectFlowResponse"/></returns>
        public DescribeMediaConnectFlowResponse DescribeMediaConnectFlowSync(DescribeMediaConnectFlowRequest req)
        {
             JsonResponseModel<DescribeMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of multiple MediaConnect flows in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaConnectFlowsRequest"/></param>
        /// <returns><see cref="DescribeMediaConnectFlowsResponse"/></returns>
        public async Task<DescribeMediaConnectFlowsResponse> DescribeMediaConnectFlows(DescribeMediaConnectFlowsRequest req)
        {
             JsonResponseModel<DescribeMediaConnectFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaConnectFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaConnectFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the configuration information of multiple MediaConnect flows in batches.
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaConnectFlowsRequest"/></param>
        /// <returns><see cref="DescribeMediaConnectFlowsResponse"/></returns>
        public DescribeMediaConnectFlowsResponse DescribeMediaConnectFlowsSync(DescribeMediaConnectFlowsRequest req)
        {
             JsonResponseModel<DescribeMediaConnectFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaConnectFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaConnectFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaConnectFlowRequest"/></param>
        /// <returns><see cref="ModifyMediaConnectFlowResponse"/></returns>
        public async Task<ModifyMediaConnectFlowResponse> ModifyMediaConnectFlow(ModifyMediaConnectFlowRequest req)
        {
             JsonResponseModel<ModifyMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the configuration information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaConnectFlowRequest"/></param>
        /// <returns><see cref="ModifyMediaConnectFlowResponse"/></returns>
        public ModifyMediaConnectFlowResponse ModifyMediaConnectFlowSync(ModifyMediaConnectFlowRequest req)
        {
             JsonResponseModel<ModifyMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the input information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaConnectInputRequest"/></param>
        /// <returns><see cref="ModifyMediaConnectInputResponse"/></returns>
        public async Task<ModifyMediaConnectInputResponse> ModifyMediaConnectInput(ModifyMediaConnectInputRequest req)
        {
             JsonResponseModel<ModifyMediaConnectInputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaConnectInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaConnectInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the input information of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaConnectInputRequest"/></param>
        /// <returns><see cref="ModifyMediaConnectInputResponse"/></returns>
        public ModifyMediaConnectInputResponse ModifyMediaConnectInputSync(ModifyMediaConnectInputRequest req)
        {
             JsonResponseModel<ModifyMediaConnectInputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaConnectInput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaConnectInputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the output configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaConnectOutputRequest"/></param>
        /// <returns><see cref="ModifyMediaConnectOutputResponse"/></returns>
        public async Task<ModifyMediaConnectOutputResponse> ModifyMediaConnectOutput(ModifyMediaConnectOutputRequest req)
        {
             JsonResponseModel<ModifyMediaConnectOutputResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyMediaConnectOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaConnectOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the output configuration of a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="ModifyMediaConnectOutputRequest"/></param>
        /// <returns><see cref="ModifyMediaConnectOutputResponse"/></returns>
        public ModifyMediaConnectOutputResponse ModifyMediaConnectOutputSync(ModifyMediaConnectOutputRequest req)
        {
             JsonResponseModel<ModifyMediaConnectOutputResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyMediaConnectOutput");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyMediaConnectOutputResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="StartMediaConnectFlowRequest"/></param>
        /// <returns><see cref="StartMediaConnectFlowResponse"/></returns>
        public async Task<StartMediaConnectFlowResponse> StartMediaConnectFlow(StartMediaConnectFlowRequest req)
        {
             JsonResponseModel<StartMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to start a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="StartMediaConnectFlowRequest"/></param>
        /// <returns><see cref="StartMediaConnectFlowResponse"/></returns>
        public StartMediaConnectFlowResponse StartMediaConnectFlowSync(StartMediaConnectFlowRequest req)
        {
             JsonResponseModel<StartMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="StopMediaConnectFlowRequest"/></param>
        /// <returns><see cref="StopMediaConnectFlowResponse"/></returns>
        public async Task<StopMediaConnectFlowResponse> StopMediaConnectFlow(StopMediaConnectFlowRequest req)
        {
             JsonResponseModel<StopMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StopMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to stop a MediaConnect flow.
        /// </summary>
        /// <param name="req"><see cref="StopMediaConnectFlowRequest"/></param>
        /// <returns><see cref="StopMediaConnectFlowResponse"/></returns>
        public StopMediaConnectFlowResponse StopMediaConnectFlowSync(StopMediaConnectFlowRequest req)
        {
             JsonResponseModel<StopMediaConnectFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StopMediaConnectFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StopMediaConnectFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
