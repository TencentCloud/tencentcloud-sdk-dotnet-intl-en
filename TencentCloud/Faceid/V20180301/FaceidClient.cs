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

namespace TencentCloud.Faceid.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Faceid.V20180301.Models;

   public class FaceidClient : AbstractClient{

       private const string endpoint = "faceid.tencentcloudapi.com";
       private const string version = "2018-03-01";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public FaceidClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to apply for a token before calling the liveness detection service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplyLivenessTokenRequest"/></param>
        /// <returns><see cref="ApplyLivenessTokenResponse"/></returns>
        public async Task<ApplyLivenessTokenResponse> ApplyLivenessToken(ApplyLivenessTokenRequest req)
        {
             JsonResponseModel<ApplyLivenessTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyLivenessToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyLivenessTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a token before calling the liveness detection service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplyLivenessTokenRequest"/></param>
        /// <returns><see cref="ApplyLivenessTokenResponse"/></returns>
        public ApplyLivenessTokenResponse ApplyLivenessTokenSync(ApplyLivenessTokenRequest req)
        {
             JsonResponseModel<ApplyLivenessTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyLivenessToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyLivenessTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a token before calling the SDK-based verification service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public async Task<ApplySdkVerificationTokenResponse> ApplySdkVerificationToken(ApplySdkVerificationTokenRequest req)
        {
             JsonResponseModel<ApplySdkVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplySdkVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySdkVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a token before calling the SDK-based verification service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public ApplySdkVerificationTokenResponse ApplySdkVerificationTokenSync(ApplySdkVerificationTokenRequest req)
        {
             JsonResponseModel<ApplySdkVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplySdkVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplySdkVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a token before calling the web-based verification service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplyWebVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplyWebVerificationTokenResponse"/></returns>
        public async Task<ApplyWebVerificationTokenResponse> ApplyWebVerificationToken(ApplyWebVerificationTokenRequest req)
        {
             JsonResponseModel<ApplyWebVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyWebVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyWebVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to apply for a token before calling the web-based verification service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplyWebVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplyWebVerificationTokenResponse"/></returns>
        public ApplyWebVerificationTokenResponse ApplyWebVerificationTokenSync(ApplyWebVerificationTokenRequest req)
        {
             JsonResponseModel<ApplyWebVerificationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyWebVerificationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyWebVerificationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate a temporary `UploadUrl` for uploading resource files (with the `HTTP PUT` method). After resource upload, `ResourceUrl` will be passed to the `TargetAction` API to complete the resource passing (specific fields vary by case). 
        /// The data will be stored in a COS bucket in the region specified by the parameter `Region` for two hours.
        /// </summary>
        /// <param name="req"><see cref="CreateUploadUrlRequest"/></param>
        /// <returns><see cref="CreateUploadUrlResponse"/></returns>
        public async Task<CreateUploadUrlResponse> CreateUploadUrl(CreateUploadUrlRequest req)
        {
             JsonResponseModel<CreateUploadUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUploadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUploadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate a temporary `UploadUrl` for uploading resource files (with the `HTTP PUT` method). After resource upload, `ResourceUrl` will be passed to the `TargetAction` API to complete the resource passing (specific fields vary by case). 
        /// The data will be stored in a COS bucket in the region specified by the parameter `Region` for two hours.
        /// </summary>
        /// <param name="req"><see cref="CreateUploadUrlRequest"/></param>
        /// <returns><see cref="CreateUploadUrlResponse"/></returns>
        public CreateUploadUrlResponse CreateUploadUrlSync(CreateUploadUrlRequest req)
        {
             JsonResponseModel<CreateUploadUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUploadUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUploadUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect liveness with the package generated by the liveness comparison (reflection-based) SDK, and to compare the person detected with that in the image passed in.
        /// The image and the data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="DetectReflectLivenessAndCompareRequest"/></param>
        /// <returns><see cref="DetectReflectLivenessAndCompareResponse"/></returns>
        public async Task<DetectReflectLivenessAndCompareResponse> DetectReflectLivenessAndCompare(DetectReflectLivenessAndCompareRequest req)
        {
             JsonResponseModel<DetectReflectLivenessAndCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectReflectLivenessAndCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectReflectLivenessAndCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect liveness with the package generated by the liveness comparison (reflection-based) SDK, and to compare the person detected with that in the image passed in.
        /// The image and the data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="DetectReflectLivenessAndCompareRequest"/></param>
        /// <returns><see cref="DetectReflectLivenessAndCompareResponse"/></returns>
        public DetectReflectLivenessAndCompareResponse DetectReflectLivenessAndCompareSync(DetectReflectLivenessAndCompareRequest req)
        {
             JsonResponseModel<DetectReflectLivenessAndCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectReflectLivenessAndCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectReflectLivenessAndCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate an appropriate light sequence based on the information collected by the liveness comparison (reflection-based) SDK and pass the light sequence into the SDK to start the identity verification process.
        /// The data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="GenerateReflectSequenceRequest"/></param>
        /// <returns><see cref="GenerateReflectSequenceResponse"/></returns>
        public async Task<GenerateReflectSequenceResponse> GenerateReflectSequence(GenerateReflectSequenceRequest req)
        {
             JsonResponseModel<GenerateReflectSequenceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GenerateReflectSequence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateReflectSequenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to generate an appropriate light sequence based on the information collected by the liveness comparison (reflection-based) SDK and pass the light sequence into the SDK to start the identity verification process.
        /// The data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="GenerateReflectSequenceRequest"/></param>
        /// <returns><see cref="GenerateReflectSequenceResponse"/></returns>
        public GenerateReflectSequenceResponse GenerateReflectSequenceSync(GenerateReflectSequenceRequest req)
        {
             JsonResponseModel<GenerateReflectSequenceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GenerateReflectSequence");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GenerateReflectSequenceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token (SdkToken) after the liveness detection is completed. The token is valid for two hours after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetLivenessResultRequest"/></param>
        /// <returns><see cref="GetLivenessResultResponse"/></returns>
        public async Task<GetLivenessResultResponse> GetLivenessResult(GetLivenessResultRequest req)
        {
             JsonResponseModel<GetLivenessResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetLivenessResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLivenessResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token (SdkToken) after the liveness detection is completed. The token is valid for two hours after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetLivenessResultRequest"/></param>
        /// <returns><see cref="GetLivenessResultResponse"/></returns>
        public GetLivenessResultResponse GetLivenessResultSync(GetLivenessResultRequest req)
        {
             JsonResponseModel<GetLivenessResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetLivenessResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetLivenessResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token after the SDK-based verification is completed. The token is valid for three days after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public async Task<GetSdkVerificationResultResponse> GetSdkVerificationResult(GetSdkVerificationResultRequest req)
        {
             JsonResponseModel<GetSdkVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSdkVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSdkVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token after the SDK-based verification is completed. The token is valid for three days after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public GetSdkVerificationResultResponse GetSdkVerificationResultSync(GetSdkVerificationResultRequest req)
        {
             JsonResponseModel<GetSdkVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSdkVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSdkVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token (BizToken) after the web-based verification is completed. The BizToken is valid for three days (3*24*3,600s) after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetWebVerificationResultRequest"/></param>
        /// <returns><see cref="GetWebVerificationResultResponse"/></returns>
        public async Task<GetWebVerificationResultResponse> GetWebVerificationResult(GetWebVerificationResultRequest req)
        {
             JsonResponseModel<GetWebVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetWebVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWebVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token (BizToken) after the web-based verification is completed. The BizToken is valid for three days (3*24*3,600s) after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetWebVerificationResultRequest"/></param>
        /// <returns><see cref="GetWebVerificationResultResponse"/></returns>
        public GetWebVerificationResultResponse GetWebVerificationResultSync(GetWebVerificationResultRequest req)
        {
             JsonResponseModel<GetWebVerificationResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetWebVerificationResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWebVerificationResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pass in a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// This API on the legacy version will continue to serve existing users but will be unavailable to new users. We recommend you use `VideoLivenessCompare` for better service quality.
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public async Task<LivenessCompareResponse> LivenessCompare(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pass in a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// This API on the legacy version will continue to serve existing users but will be unavailable to new users. We recommend you use `VideoLivenessCompare` for better service quality.
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public LivenessCompareResponse LivenessCompareSync(LivenessCompareRequest req)
        {
             JsonResponseModel<LivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pass in URLs of a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// </summary>
        /// <param name="req"><see cref="VideoLivenessCompareRequest"/></param>
        /// <returns><see cref="VideoLivenessCompareResponse"/></returns>
        public async Task<VideoLivenessCompareResponse> VideoLivenessCompare(VideoLivenessCompareRequest req)
        {
             JsonResponseModel<VideoLivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VideoLivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoLivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to pass in URLs of a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// </summary>
        /// <param name="req"><see cref="VideoLivenessCompareRequest"/></param>
        /// <returns><see cref="VideoLivenessCompareResponse"/></returns>
        public VideoLivenessCompareResponse VideoLivenessCompareSync(VideoLivenessCompareRequest req)
        {
             JsonResponseModel<VideoLivenessCompareResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VideoLivenessCompare");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VideoLivenessCompareResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
