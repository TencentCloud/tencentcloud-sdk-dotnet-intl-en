/*
 * Copyright (c) 2018 Tencent. All Rights Reserved.
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

       private const string endpoint = "sts.intl.tencentcloudapi.com";
       private const string version = "2018-08-13";
       private const string sdkVersion = "SDK_NET_3.0.1303";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public StsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to request temporary access credentials for assuming a role.
        /// 
        /// This API is used to describe the composition of role policies.
        /// 
        /// This API is used to specify the role trust policy, which defines who can assume the role.
        /// 
        /// This API is used to specify the role permission policy, which defines what actions can be performed after assuming the role.
        /// 
        /// 
        /// This API is used to describe the conditions under which a role can be assumed.
        /// 
        /// This API is used to bind a policy that allows a user to call AssumeRole.
        /// 
        /// This API is used to add a user as a principal in the role trust policy.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public Task<AssumeRoleResponse> AssumeRole(AssumeRoleRequest req)
        {
            return InternalRequestAsync<AssumeRoleResponse>(req, "AssumeRole");
        }

        /// <summary>
        /// This API is used to request temporary access credentials for assuming a role.
        /// 
        /// This API is used to describe the composition of role policies.
        /// 
        /// This API is used to specify the role trust policy, which defines who can assume the role.
        /// 
        /// This API is used to specify the role permission policy, which defines what actions can be performed after assuming the role.
        /// 
        /// 
        /// This API is used to describe the conditions under which a role can be assumed.
        /// 
        /// This API is used to bind a policy that allows a user to call AssumeRole.
        /// 
        /// This API is used to add a user as a principal in the role trust policy.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public AssumeRoleResponse AssumeRoleSync(AssumeRoleRequest req)
        {
            return InternalRequestAsync<AssumeRoleResponse>(req, "AssumeRole")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to request temporary access credentials for a role based on a SAML assertion.
        /// 
        /// Note: When called with signature method v3, header `X-TC-Token` could be ignored, and `Authorization` should be SKIP.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAML(AssumeRoleWithSAMLRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithSAMLResponse>(req, "AssumeRoleWithSAML");
        }

        /// <summary>
        /// This API is used to request temporary access credentials for a role based on a SAML assertion.
        /// 
        /// Note: When called with signature method v3, header `X-TC-Token` could be ignored, and `Authorization` should be SKIP.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAMLSync(AssumeRoleWithSAMLRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithSAMLResponse>(req, "AssumeRoleWithSAML")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for an OIDC role credential.
        /// 
        /// Note: When called with signature method v3, header `X-TC-Token` could be ignored, and `Authorization` should be SKIP.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithWebIdentityResponse>(req, "AssumeRoleWithWebIdentity");
        }

        /// <summary>
        /// This API is used to apply for an OIDC role credential.
        /// 
        /// Note: When called with signature method v3, header `X-TC-Token` could be ignored, and `Authorization` should be SKIP.
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentitySync(AssumeRoleWithWebIdentityRequest req)
        {
            return InternalRequestAsync<AssumeRoleWithWebIdentityResponse>(req, "AssumeRoleWithWebIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the identity information of the current caller.
        /// 
        /// This API is used to get the identity information using the persistent keys of the root account and sub-account as well as the temporary credentials generated by AssumeRole and GetFederationToken.
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public Task<GetCallerIdentityResponse> GetCallerIdentity(GetCallerIdentityRequest req)
        {
            return InternalRequestAsync<GetCallerIdentityResponse>(req, "GetCallerIdentity");
        }

        /// <summary>
        /// This API is used to get the identity information of the current caller.
        /// 
        /// This API is used to get the identity information using the persistent keys of the root account and sub-account as well as the temporary credentials generated by AssumeRole and GetFederationToken.
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public GetCallerIdentityResponse GetCallerIdentitySync(GetCallerIdentityRequest req)
        {
            return InternalRequestAsync<GetCallerIdentityResponse>(req, "GetCallerIdentity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to provide instructions.
        /// 
        /// This API is used to return a set of temporary access credentials. A typical application scenario is for proxy applications to centrally request temporary access credentials and distribute them to other distributed terminal applications within the enterprise network, such as terminal applications uploading files to COS. This API only supports calls with permanent keys.
        /// 
        /// This API is used to implement best practices.
        /// 
        /// 1. This API is used to recommend reusing temporary access credentials within their validity period to avoid rate limiting due to increased business request rates.
        /// 2. This API is used to recommend granting temporary access credentials with the principle of least privilege.
        /// 3. This API is used to recommend not using the root account for permanent keys calling the API.
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public Task<GetFederationTokenResponse> GetFederationToken(GetFederationTokenRequest req)
        {
            return InternalRequestAsync<GetFederationTokenResponse>(req, "GetFederationToken");
        }

        /// <summary>
        /// This API is used to provide instructions.
        /// 
        /// This API is used to return a set of temporary access credentials. A typical application scenario is for proxy applications to centrally request temporary access credentials and distribute them to other distributed terminal applications within the enterprise network, such as terminal applications uploading files to COS. This API only supports calls with permanent keys.
        /// 
        /// This API is used to implement best practices.
        /// 
        /// 1. This API is used to recommend reusing temporary access credentials within their validity period to avoid rate limiting due to increased business request rates.
        /// 2. This API is used to recommend granting temporary access credentials with the principle of least privilege.
        /// 3. This API is used to recommend not using the root account for permanent keys calling the API.
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public GetFederationTokenResponse GetFederationTokenSync(GetFederationTokenRequest req)
        {
            return InternalRequestAsync<GetFederationTokenResponse>(req, "GetFederationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
