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

namespace TencentCloud.Cloudaudit.V20190319
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cloudaudit.V20190319.Models;

   public class CloudauditClient : AbstractClient{

       private const string endpoint = "cloudaudit.tencentcloudapi.com";
       private const string version = "2019-03-19";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudauditClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public CloudauditClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to query the CloudAudit tracking set list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public async Task<DescribeAuditTracksResponse> DescribeAuditTracks(DescribeAuditTracksRequest req)
        {
             JsonResponseModel<DescribeAuditTracksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAuditTracks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditTracksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query the CloudAudit tracking set list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public DescribeAuditTracksResponse DescribeAuditTracksSync(DescribeAuditTracksRequest req)
        {
             JsonResponseModel<DescribeAuditTracksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAuditTracks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAuditTracksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CloudAudit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public async Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
             JsonResponseModel<DescribeEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query CloudAudit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
             JsonResponseModel<DescribeEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
