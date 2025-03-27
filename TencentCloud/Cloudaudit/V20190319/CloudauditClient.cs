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

       private const string endpoint = "cloudaudit.intl.tencentcloudapi.com";
       private const string version = "2019-03-19";
       private const string sdkVersion = "SDK_NET_3.0.1099";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public CloudauditClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// Parameter requirements:
        /// 1. If the value of `IsCreateNewBucket` exists, `cosRegion` and `osBucketName` are required.
        /// 2. If the value of `IsEnableCmqNotify` is 1, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` are required.
        /// 3. If the value of `IsEnableCmqNotify` is 0, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` cannot be passed in.
        /// 4. If the value of `IsEnableKmsEncry` is 1, `KmsRegion` and `KeyId` are required.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRequest"/></param>
        /// <returns><see cref="CreateAuditResponse"/></returns>
        public Task<CreateAuditResponse> CreateAudit(CreateAuditRequest req)
        {
            return InternalRequestAsync<CreateAuditResponse>(req, "CreateAudit");
        }

        /// <summary>
        /// Parameter requirements:
        /// 1. If the value of `IsCreateNewBucket` exists, `cosRegion` and `osBucketName` are required.
        /// 2. If the value of `IsEnableCmqNotify` is 1, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` are required.
        /// 3. If the value of `IsEnableCmqNotify` is 0, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` cannot be passed in.
        /// 4. If the value of `IsEnableKmsEncry` is 1, `KmsRegion` and `KeyId` are required.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditRequest"/></param>
        /// <returns><see cref="CreateAuditResponse"/></returns>
        public CreateAuditResponse CreateAuditSync(CreateAuditRequest req)
        {
            return InternalRequestAsync<CreateAuditResponse>(req, "CreateAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a tracking set.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditTrackRequest"/></param>
        /// <returns><see cref="CreateAuditTrackResponse"/></returns>
        public Task<CreateAuditTrackResponse> CreateAuditTrack(CreateAuditTrackRequest req)
        {
            return InternalRequestAsync<CreateAuditTrackResponse>(req, "CreateAuditTrack");
        }

        /// <summary>
        /// This API is used to create a tracking set.
        /// </summary>
        /// <param name="req"><see cref="CreateAuditTrackRequest"/></param>
        /// <returns><see cref="CreateAuditTrackResponse"/></returns>
        public CreateAuditTrackResponse CreateAuditTrackSync(CreateAuditTrackRequest req)
        {
            return InternalRequestAsync<CreateAuditTrackResponse>(req, "CreateAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a tracking set.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRequest"/></param>
        /// <returns><see cref="DeleteAuditResponse"/></returns>
        public Task<DeleteAuditResponse> DeleteAudit(DeleteAuditRequest req)
        {
            return InternalRequestAsync<DeleteAuditResponse>(req, "DeleteAudit");
        }

        /// <summary>
        /// This API is used to delete a tracking set.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditRequest"/></param>
        /// <returns><see cref="DeleteAuditResponse"/></returns>
        public DeleteAuditResponse DeleteAuditSync(DeleteAuditRequest req)
        {
            return InternalRequestAsync<DeleteAuditResponse>(req, "DeleteAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a CloudAudit tracking set.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditTrackRequest"/></param>
        /// <returns><see cref="DeleteAuditTrackResponse"/></returns>
        public Task<DeleteAuditTrackResponse> DeleteAuditTrack(DeleteAuditTrackRequest req)
        {
            return InternalRequestAsync<DeleteAuditTrackResponse>(req, "DeleteAuditTrack");
        }

        /// <summary>
        /// This API is used to delete a CloudAudit tracking set.
        /// </summary>
        /// <param name="req"><see cref="DeleteAuditTrackRequest"/></param>
        /// <returns><see cref="DeleteAuditTrackResponse"/></returns>
        public DeleteAuditTrackResponse DeleteAuditTrackSync(DeleteAuditTrackRequest req)
        {
            return InternalRequestAsync<DeleteAuditTrackResponse>(req, "DeleteAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the details of a tracking set.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRequest"/></param>
        /// <returns><see cref="DescribeAuditResponse"/></returns>
        public Task<DescribeAuditResponse> DescribeAudit(DescribeAuditRequest req)
        {
            return InternalRequestAsync<DescribeAuditResponse>(req, "DescribeAudit");
        }

        /// <summary>
        /// This API is used to query the details of a tracking set.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditRequest"/></param>
        /// <returns><see cref="DescribeAuditResponse"/></returns>
        public DescribeAuditResponse DescribeAuditSync(DescribeAuditRequest req)
        {
            return InternalRequestAsync<DescribeAuditResponse>(req, "DescribeAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CloudAudit tracking set details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTrackRequest"/></param>
        /// <returns><see cref="DescribeAuditTrackResponse"/></returns>
        public Task<DescribeAuditTrackResponse> DescribeAuditTrack(DescribeAuditTrackRequest req)
        {
            return InternalRequestAsync<DescribeAuditTrackResponse>(req, "DescribeAuditTrack");
        }

        /// <summary>
        /// This API is used to query the CloudAudit tracking set details.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTrackRequest"/></param>
        /// <returns><see cref="DescribeAuditTrackResponse"/></returns>
        public DescribeAuditTrackResponse DescribeAuditTrackSync(DescribeAuditTrackRequest req)
        {
            return InternalRequestAsync<DescribeAuditTrackResponse>(req, "DescribeAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the CloudAudit tracking set list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public Task<DescribeAuditTracksResponse> DescribeAuditTracks(DescribeAuditTracksRequest req)
        {
            return InternalRequestAsync<DescribeAuditTracksResponse>(req, "DescribeAuditTracks");
        }

        /// <summary>
        /// This API is used to query the CloudAudit tracking set list.
        /// </summary>
        /// <param name="req"><see cref="DescribeAuditTracksRequest"/></param>
        /// <returns><see cref="DescribeAuditTracksResponse"/></returns>
        public DescribeAuditTracksResponse DescribeAuditTracksSync(DescribeAuditTracksRequest req)
        {
            return InternalRequestAsync<DescribeAuditTracksResponse>(req, "DescribeAuditTracks")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CloudAudit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public Task<DescribeEventsResponse> DescribeEvents(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents");
        }

        /// <summary>
        /// This API is used to query CloudAudit logs.
        /// </summary>
        /// <param name="req"><see cref="DescribeEventsRequest"/></param>
        /// <returns><see cref="DescribeEventsResponse"/></returns>
        public DescribeEventsResponse DescribeEventsSync(DescribeEventsRequest req)
        {
            return InternalRequestAsync<DescribeEventsResponse>(req, "DescribeEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the valid values of `AttributeKey`.
        /// </summary>
        /// <param name="req"><see cref="GetAttributeKeyRequest"/></param>
        /// <returns><see cref="GetAttributeKeyResponse"/></returns>
        public Task<GetAttributeKeyResponse> GetAttributeKey(GetAttributeKeyRequest req)
        {
            return InternalRequestAsync<GetAttributeKeyResponse>(req, "GetAttributeKey");
        }

        /// <summary>
        /// This API is used to query the valid values of `AttributeKey`.
        /// </summary>
        /// <param name="req"><see cref="GetAttributeKeyRequest"/></param>
        /// <returns><see cref="GetAttributeKeyResponse"/></returns>
        public GetAttributeKeyResponse GetAttributeKeySync(GetAttributeKeyRequest req)
        {
            return InternalRequestAsync<GetAttributeKeyResponse>(req, "GetAttributeKey")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the number of tracking sets that can be created.
        /// </summary>
        /// <param name="req"><see cref="InquireAuditCreditRequest"/></param>
        /// <returns><see cref="InquireAuditCreditResponse"/></returns>
        public Task<InquireAuditCreditResponse> InquireAuditCredit(InquireAuditCreditRequest req)
        {
            return InternalRequestAsync<InquireAuditCreditResponse>(req, "InquireAuditCredit");
        }

        /// <summary>
        /// This API is used to query the number of tracking sets that can be created.
        /// </summary>
        /// <param name="req"><see cref="InquireAuditCreditRequest"/></param>
        /// <returns><see cref="InquireAuditCreditResponse"/></returns>
        public InquireAuditCreditResponse InquireAuditCreditSync(InquireAuditCreditRequest req)
        {
            return InternalRequestAsync<InquireAuditCreditResponse>(req, "InquireAuditCredit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the summary of tracking sets.
        /// </summary>
        /// <param name="req"><see cref="ListAuditsRequest"/></param>
        /// <returns><see cref="ListAuditsResponse"/></returns>
        public Task<ListAuditsResponse> ListAudits(ListAuditsRequest req)
        {
            return InternalRequestAsync<ListAuditsResponse>(req, "ListAudits");
        }

        /// <summary>
        /// This API is used to query the summary of tracking sets.
        /// </summary>
        /// <param name="req"><see cref="ListAuditsRequest"/></param>
        /// <returns><see cref="ListAuditsResponse"/></returns>
        public ListAuditsResponse ListAuditsSync(ListAuditsRequest req)
        {
            return InternalRequestAsync<ListAuditsResponse>(req, "ListAudits")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CloudAudit-enabled CMQ AZs.
        /// </summary>
        /// <param name="req"><see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns><see cref="ListCmqEnableRegionResponse"/></returns>
        public Task<ListCmqEnableRegionResponse> ListCmqEnableRegion(ListCmqEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCmqEnableRegionResponse>(req, "ListCmqEnableRegion");
        }

        /// <summary>
        /// This API is used to query CloudAudit-enabled CMQ AZs.
        /// </summary>
        /// <param name="req"><see cref="ListCmqEnableRegionRequest"/></param>
        /// <returns><see cref="ListCmqEnableRegionResponse"/></returns>
        public ListCmqEnableRegionResponse ListCmqEnableRegionSync(ListCmqEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCmqEnableRegionResponse>(req, "ListCmqEnableRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query CloudAudit-enabled COS AZs.
        /// </summary>
        /// <param name="req"><see cref="ListCosEnableRegionRequest"/></param>
        /// <returns><see cref="ListCosEnableRegionResponse"/></returns>
        public Task<ListCosEnableRegionResponse> ListCosEnableRegion(ListCosEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCosEnableRegionResponse>(req, "ListCosEnableRegion");
        }

        /// <summary>
        /// This API is used to query CloudAudit-enabled COS AZs.
        /// </summary>
        /// <param name="req"><see cref="ListCosEnableRegionRequest"/></param>
        /// <returns><see cref="ListCosEnableRegionResponse"/></returns>
        public ListCosEnableRegionResponse ListCosEnableRegionSync(ListCosEnableRegionRequest req)
        {
            return InternalRequestAsync<ListCosEnableRegionResponse>(req, "ListCosEnableRegion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to search for operation logs to help query relevant operation information.
        /// </summary>
        /// <param name="req"><see cref="LookUpEventsRequest"/></param>
        /// <returns><see cref="LookUpEventsResponse"/></returns>
        public Task<LookUpEventsResponse> LookUpEvents(LookUpEventsRequest req)
        {
            return InternalRequestAsync<LookUpEventsResponse>(req, "LookUpEvents");
        }

        /// <summary>
        /// This API is used to search for operation logs to help query relevant operation information.
        /// </summary>
        /// <param name="req"><see cref="LookUpEventsRequest"/></param>
        /// <returns><see cref="LookUpEventsResponse"/></returns>
        public LookUpEventsResponse LookUpEventsSync(LookUpEventsRequest req)
        {
            return InternalRequestAsync<LookUpEventsResponse>(req, "LookUpEvents")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a CloudAudit tracking set.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyAuditTrackResponse"/></returns>
        public Task<ModifyAuditTrackResponse> ModifyAuditTrack(ModifyAuditTrackRequest req)
        {
            return InternalRequestAsync<ModifyAuditTrackResponse>(req, "ModifyAuditTrack");
        }

        /// <summary>
        /// This API is used to modify a CloudAudit tracking set.
        /// </summary>
        /// <param name="req"><see cref="ModifyAuditTrackRequest"/></param>
        /// <returns><see cref="ModifyAuditTrackResponse"/></returns>
        public ModifyAuditTrackResponse ModifyAuditTrackSync(ModifyAuditTrackRequest req)
        {
            return InternalRequestAsync<ModifyAuditTrackResponse>(req, "ModifyAuditTrack")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to enable a tracking set.
        /// </summary>
        /// <param name="req"><see cref="StartLoggingRequest"/></param>
        /// <returns><see cref="StartLoggingResponse"/></returns>
        public Task<StartLoggingResponse> StartLogging(StartLoggingRequest req)
        {
            return InternalRequestAsync<StartLoggingResponse>(req, "StartLogging");
        }

        /// <summary>
        /// This API is used to enable a tracking set.
        /// </summary>
        /// <param name="req"><see cref="StartLoggingRequest"/></param>
        /// <returns><see cref="StartLoggingResponse"/></returns>
        public StartLoggingResponse StartLoggingSync(StartLoggingRequest req)
        {
            return InternalRequestAsync<StartLoggingResponse>(req, "StartLogging")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to disable a tracking set.
        /// </summary>
        /// <param name="req"><see cref="StopLoggingRequest"/></param>
        /// <returns><see cref="StopLoggingResponse"/></returns>
        public Task<StopLoggingResponse> StopLogging(StopLoggingRequest req)
        {
            return InternalRequestAsync<StopLoggingResponse>(req, "StopLogging");
        }

        /// <summary>
        /// This API is used to disable a tracking set.
        /// </summary>
        /// <param name="req"><see cref="StopLoggingRequest"/></param>
        /// <returns><see cref="StopLoggingResponse"/></returns>
        public StopLoggingResponse StopLoggingSync(StopLoggingRequest req)
        {
            return InternalRequestAsync<StopLoggingResponse>(req, "StopLogging")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Parameter requirements:
        /// 1. If the value of `IsCreateNewBucket` exists, `cosRegion` and `osBucketName` are required.
        /// 2. If the value of `IsEnableCmqNotify` is 1, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` are required.
        /// 3. If the value of `IsEnableCmqNotify` is 0, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` cannot be passed in.
        /// 4. If the value of `IsEnableKmsEncry` is 1, `KmsRegion` and `KeyId` are required.
        /// </summary>
        /// <param name="req"><see cref="UpdateAuditRequest"/></param>
        /// <returns><see cref="UpdateAuditResponse"/></returns>
        public Task<UpdateAuditResponse> UpdateAudit(UpdateAuditRequest req)
        {
            return InternalRequestAsync<UpdateAuditResponse>(req, "UpdateAudit");
        }

        /// <summary>
        /// Parameter requirements:
        /// 1. If the value of `IsCreateNewBucket` exists, `cosRegion` and `osBucketName` are required.
        /// 2. If the value of `IsEnableCmqNotify` is 1, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` are required.
        /// 3. If the value of `IsEnableCmqNotify` is 0, `IsCreateNewQueue`, `CmqRegion`, and `CmqQueueName` cannot be passed in.
        /// 4. If the value of `IsEnableKmsEncry` is 1, `KmsRegion` and `KeyId` are required.
        /// </summary>
        /// <param name="req"><see cref="UpdateAuditRequest"/></param>
        /// <returns><see cref="UpdateAuditResponse"/></returns>
        public UpdateAuditResponse UpdateAuditSync(UpdateAuditRequest req)
        {
            return InternalRequestAsync<UpdateAuditResponse>(req, "UpdateAudit")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
