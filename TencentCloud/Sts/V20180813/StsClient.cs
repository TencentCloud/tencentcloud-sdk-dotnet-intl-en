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

namespace TencentCloud.Sts.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sts.V20180813.Models;

   public class StsClient : AbstractClient{

       private const string endpoint = "sts.tencentcloudapi.com";
       private const string version = "2018-08-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public StsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public StsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to request for the temporary security credentials of a role.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public async Task<AssumeRoleResponse> AssumeRole(AssumeRoleRequest req)
        {
             JsonResponseModel<AssumeRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to request for the temporary security credentials of a role.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public AssumeRoleResponse AssumeRoleSync(AssumeRoleRequest req)
        {
             JsonResponseModel<AssumeRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to request for the temporary credentials for a role that has been authenticated via a SAML assertion.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAML(AssumeRoleWithSAMLRequest req)
        {
             JsonResponseModel<AssumeRoleWithSAMLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRoleWithSAML");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithSAMLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to request for the temporary credentials for a role that has been authenticated via a SAML assertion.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAMLSync(AssumeRoleWithSAMLRequest req)
        {
             JsonResponseModel<AssumeRoleWithSAMLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRoleWithSAML");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithSAMLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for an OIDC role credential.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public async Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest req)
        {
             JsonResponseModel<AssumeRoleWithWebIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRoleWithWebIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithWebIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for an OIDC role credential.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentitySync(AssumeRoleWithWebIdentityRequest req)
        {
             JsonResponseModel<AssumeRoleWithWebIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRoleWithWebIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithWebIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the identity information of the current caller.
        /// The persistent keys of the root account and sub-account as well as the temporary credentials generated by `AssumeRole` and `GetFederationToken` can be used to get the identity information.
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public async Task<GetCallerIdentityResponse> GetCallerIdentity(GetCallerIdentityRequest req)
        {
             JsonResponseModel<GetCallerIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCallerIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCallerIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the identity information of the current caller.
        /// The persistent keys of the root account and sub-account as well as the temporary credentials generated by `AssumeRole` and `GetFederationToken` can be used to get the identity information.
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public GetCallerIdentityResponse GetCallerIdentitySync(GetCallerIdentityRequest req)
        {
             JsonResponseModel<GetCallerIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCallerIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCallerIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get temporary credentials for a federated user.
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public async Task<GetFederationTokenResponse> GetFederationToken(GetFederationTokenRequest req)
        {
             JsonResponseModel<GetFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get temporary credentials for a federated user.
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public GetFederationTokenResponse GetFederationTokenSync(GetFederationTokenRequest req)
        {
             JsonResponseModel<GetFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
