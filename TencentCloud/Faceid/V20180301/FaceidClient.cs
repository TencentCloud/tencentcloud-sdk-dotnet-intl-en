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

namespace TencentCloud.Faceid.V20180301
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Faceid.V20180301.Models;

   public class FaceidClient : AbstractClient{

       private const string endpoint = "faceid.intl.tencentcloudapi.com";
       private const string version = "2018-03-01";
       private const string sdkVersion = "SDK_NET_3.0.1301";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public FaceidClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to apply for a token before calling the liveness detection service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplyLivenessTokenRequest"/></param>
        /// <returns><see cref="ApplyLivenessTokenResponse"/></returns>
        public Task<ApplyLivenessTokenResponse> ApplyLivenessToken(ApplyLivenessTokenRequest req)
        {
            return InternalRequestAsync<ApplyLivenessTokenResponse>(req, "ApplyLivenessToken");
        }

        /// <summary>
        /// This API is used to apply for a token before calling the liveness detection service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplyLivenessTokenRequest"/></param>
        /// <returns><see cref="ApplyLivenessTokenResponse"/></returns>
        public ApplyLivenessTokenResponse ApplyLivenessTokenSync(ApplyLivenessTokenRequest req)
        {
            return InternalRequestAsync<ApplyLivenessTokenResponse>(req, "ApplyLivenessToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for a token before calling the eKYC SDK service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public Task<ApplySdkVerificationTokenResponse> ApplySdkVerificationToken(ApplySdkVerificationTokenRequest req)
        {
            return InternalRequestAsync<ApplySdkVerificationTokenResponse>(req, "ApplySdkVerificationToken");
        }

        /// <summary>
        /// This API is used to apply for a token before calling the eKYC SDK service each time. This token is required for initiating the verification process and getting the result after the verification is completed.
        /// </summary>
        /// <param name="req"><see cref="ApplySdkVerificationTokenRequest"/></param>
        /// <returns><see cref="ApplySdkVerificationTokenResponse"/></returns>
        public ApplySdkVerificationTokenResponse ApplySdkVerificationTokenSync(ApplySdkVerificationTokenRequest req)
        {
            return InternalRequestAsync<ApplySdkVerificationTokenResponse>(req, "ApplySdkVerificationToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain a BizToken before each call to the Web verification service. Save the BizToken to initiate the verification process and retrieve the result upon completion. The BizToken is valid for 10 minutes.
        /// </summary>
        /// <param name="req"><see cref="ApplyWebVerificationBizTokenIntlRequest"/></param>
        /// <returns><see cref="ApplyWebVerificationBizTokenIntlResponse"/></returns>
        public Task<ApplyWebVerificationBizTokenIntlResponse> ApplyWebVerificationBizTokenIntl(ApplyWebVerificationBizTokenIntlRequest req)
        {
            return InternalRequestAsync<ApplyWebVerificationBizTokenIntlResponse>(req, "ApplyWebVerificationBizTokenIntl");
        }

        /// <summary>
        /// This API is used to obtain a BizToken before each call to the Web verification service. Save the BizToken to initiate the verification process and retrieve the result upon completion. The BizToken is valid for 10 minutes.
        /// </summary>
        /// <param name="req"><see cref="ApplyWebVerificationBizTokenIntlRequest"/></param>
        /// <returns><see cref="ApplyWebVerificationBizTokenIntlResponse"/></returns>
        public ApplyWebVerificationBizTokenIntlResponse ApplyWebVerificationBizTokenIntlSync(ApplyWebVerificationBizTokenIntlRequest req)
        {
            return InternalRequestAsync<ApplyWebVerificationBizTokenIntlResponse>(req, "ApplyWebVerificationBizTokenIntl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to validate the authenticity and consistency of the name and bank card number.
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public Task<BankCard2EVerificationResponse> BankCard2EVerification(BankCard2EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard2EVerificationResponse>(req, "BankCard2EVerification");
        }

        /// <summary>
        /// This API is used to validate the authenticity and consistency of the name and bank card number.
        /// </summary>
        /// <param name="req"><see cref="BankCard2EVerificationRequest"/></param>
        /// <returns><see cref="BankCard2EVerificationResponse"/></returns>
        public BankCard2EVerificationResponse BankCard2EVerificationSync(BankCard2EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard2EVerificationResponse>(req, "BankCard2EVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify the authenticity and consistency of the bank card number, name, ID number, and mobile number for account opening.
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public Task<BankCard4EVerificationResponse> BankCard4EVerification(BankCard4EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard4EVerificationResponse>(req, "BankCard4EVerification");
        }

        /// <summary>
        /// This API is used to verify the authenticity and consistency of the bank card number, name, ID number, and mobile number for account opening.
        /// </summary>
        /// <param name="req"><see cref="BankCard4EVerificationRequest"/></param>
        /// <returns><see cref="BankCard4EVerificationResponse"/></returns>
        public BankCard4EVerificationResponse BankCard4EVerificationSync(BankCard4EVerificationRequest req)
        {
            return InternalRequestAsync<BankCard4EVerificationResponse>(req, "BankCard4EVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to verify the authenticity and consistency of the bank card number, name, and ID number of information.
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
        public Task<BankCardVerificationResponse> BankCardVerification(BankCardVerificationRequest req)
        {
            return InternalRequestAsync<BankCardVerificationResponse>(req, "BankCardVerification");
        }

        /// <summary>
        /// This API is used to verify the authenticity and consistency of the bank card number, name, and ID number of information.
        /// </summary>
        /// <param name="req"><see cref="BankCardVerificationRequest"/></param>
        /// <returns><see cref="BankCardVerificationResponse"/></returns>
        public BankCardVerificationResponse BankCardVerificationSync(BankCardVerificationRequest req)
        {
            return InternalRequestAsync<BankCardVerificationResponse>(req, "BankCardVerification")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bank card basic information query
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public Task<CheckBankCardInformationResponse> CheckBankCardInformation(CheckBankCardInformationRequest req)
        {
            return InternalRequestAsync<CheckBankCardInformationResponse>(req, "CheckBankCardInformation");
        }

        /// <summary>
        /// Bank card basic information query
        /// </summary>
        /// <param name="req"><see cref="CheckBankCardInformationRequest"/></param>
        /// <returns><see cref="CheckBankCardInformationResponse"/></returns>
        public CheckBankCardInformationResponse CheckBankCardInformationSync(CheckBankCardInformationRequest req)
        {
            return InternalRequestAsync<CheckBankCardInformationResponse>(req, "CheckBankCardInformation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This interface supports judgment of real person and photo comparison to verify the user's identity online. By passing the video and photo into the interface, it will first judge whether the person in the video is real. If yes, it judges whether the person in the video is the same one as the uploaded photo and returns authentication result.
        /// </summary>
        /// <param name="req"><see cref="CompareFaceLivenessRequest"/></param>
        /// <returns><see cref="CompareFaceLivenessResponse"/></returns>
        public Task<CompareFaceLivenessResponse> CompareFaceLiveness(CompareFaceLivenessRequest req)
        {
            return InternalRequestAsync<CompareFaceLivenessResponse>(req, "CompareFaceLiveness");
        }

        /// <summary>
        /// This interface supports judgment of real person and photo comparison to verify the user's identity online. By passing the video and photo into the interface, it will first judge whether the person in the video is real. If yes, it judges whether the person in the video is the same one as the uploaded photo and returns authentication result.
        /// </summary>
        /// <param name="req"><see cref="CompareFaceLivenessRequest"/></param>
        /// <returns><see cref="CompareFaceLivenessResponse"/></returns>
        public CompareFaceLivenessResponse CompareFaceLivenessSync(CompareFaceLivenessRequest req)
        {
            return InternalRequestAsync<CompareFaceLivenessResponse>(req, "CompareFaceLiveness")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate a temporary `UploadUrl` for uploading resource files (with the `HTTP PUT` method). After resource upload, `ResourceUrl` will be passed to the `TargetAction` API to complete the resource passing (specific fields vary by case). 
        /// The data will be stored in a COS bucket in the region specified by the parameter `Region` for two hours.
        /// </summary>
        /// <param name="req"><see cref="CreateUploadUrlRequest"/></param>
        /// <returns><see cref="CreateUploadUrlResponse"/></returns>
        public Task<CreateUploadUrlResponse> CreateUploadUrl(CreateUploadUrlRequest req)
        {
            return InternalRequestAsync<CreateUploadUrlResponse>(req, "CreateUploadUrl");
        }

        /// <summary>
        /// This API is used to generate a temporary `UploadUrl` for uploading resource files (with the `HTTP PUT` method). After resource upload, `ResourceUrl` will be passed to the `TargetAction` API to complete the resource passing (specific fields vary by case). 
        /// The data will be stored in a COS bucket in the region specified by the parameter `Region` for two hours.
        /// </summary>
        /// <param name="req"><see cref="CreateUploadUrlRequest"/></param>
        /// <returns><see cref="CreateUploadUrlResponse"/></returns>
        public CreateUploadUrlResponse CreateUploadUrlSync(CreateUploadUrlRequest req)
        {
            return InternalRequestAsync<CreateUploadUrlResponse>(req, "CreateUploadUrl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Based on the multimodal AI large model algorithm, it provides anti-attack detection capabilities for facial images and videos. It can effectively identify highly simulated AIGC face-changing, high-definition remakes, batch black market attacks, watermarks and other attack traces, and enhance the anti-counterfeiting security capabilities of images and videos.
        /// </summary>
        /// <param name="req"><see cref="DetectAIFakeFacesRequest"/></param>
        /// <returns><see cref="DetectAIFakeFacesResponse"/></returns>
        public Task<DetectAIFakeFacesResponse> DetectAIFakeFaces(DetectAIFakeFacesRequest req)
        {
            return InternalRequestAsync<DetectAIFakeFacesResponse>(req, "DetectAIFakeFaces");
        }

        /// <summary>
        /// Based on the multimodal AI large model algorithm, it provides anti-attack detection capabilities for facial images and videos. It can effectively identify highly simulated AIGC face-changing, high-definition remakes, batch black market attacks, watermarks and other attack traces, and enhance the anti-counterfeiting security capabilities of images and videos.
        /// </summary>
        /// <param name="req"><see cref="DetectAIFakeFacesRequest"/></param>
        /// <returns><see cref="DetectAIFakeFacesResponse"/></returns>
        public DetectAIFakeFacesResponse DetectAIFakeFacesSync(DetectAIFakeFacesRequest req)
        {
            return InternalRequestAsync<DetectAIFakeFacesResponse>(req, "DetectAIFakeFaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect liveness with the package generated by the liveness comparison (reflection-based) SDK, and to compare the person detected with that in the image passed in.
        /// The image and the data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="DetectReflectLivenessAndCompareRequest"/></param>
        /// <returns><see cref="DetectReflectLivenessAndCompareResponse"/></returns>
        public Task<DetectReflectLivenessAndCompareResponse> DetectReflectLivenessAndCompare(DetectReflectLivenessAndCompareRequest req)
        {
            return InternalRequestAsync<DetectReflectLivenessAndCompareResponse>(req, "DetectReflectLivenessAndCompare");
        }

        /// <summary>
        /// This API is used to detect liveness with the package generated by the liveness comparison (reflection-based) SDK, and to compare the person detected with that in the image passed in.
        /// The image and the data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="DetectReflectLivenessAndCompareRequest"/></param>
        /// <returns><see cref="DetectReflectLivenessAndCompareResponse"/></returns>
        public DetectReflectLivenessAndCompareResponse DetectReflectLivenessAndCompareSync(DetectReflectLivenessAndCompareRequest req)
        {
            return InternalRequestAsync<DetectReflectLivenessAndCompareResponse>(req, "DetectReflectLivenessAndCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to generate an appropriate light sequence based on the information collected by the liveness comparison (reflection-based) SDK and pass the light sequence into the SDK to start the eKYC process.
        /// The data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="GenerateReflectSequenceRequest"/></param>
        /// <returns><see cref="GenerateReflectSequenceResponse"/></returns>
        public Task<GenerateReflectSequenceResponse> GenerateReflectSequence(GenerateReflectSequenceRequest req)
        {
            return InternalRequestAsync<GenerateReflectSequenceResponse>(req, "GenerateReflectSequence");
        }

        /// <summary>
        /// This API is used to generate an appropriate light sequence based on the information collected by the liveness comparison (reflection-based) SDK and pass the light sequence into the SDK to start the eKYC process.
        /// The data generated with the SDK must be stored in COS, and the region of the COS bucket must be same as that of requests made with this API. We recommend that you pass resources with upload link APIs.
        /// </summary>
        /// <param name="req"><see cref="GenerateReflectSequenceRequest"/></param>
        /// <returns><see cref="GenerateReflectSequenceResponse"/></returns>
        public GenerateReflectSequenceResponse GenerateReflectSequenceSync(GenerateReflectSequenceRequest req)
        {
            return InternalRequestAsync<GenerateReflectSequenceResponse>(req, "GenerateReflectSequence")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding SDK token after the identity verification process is completed. The SDK token is valid for 72 hours (72*3600s) after generation and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultIntlRequest"/></param>
        /// <returns><see cref="GetFaceIdResultIntlResponse"/></returns>
        public Task<GetFaceIdResultIntlResponse> GetFaceIdResultIntl(GetFaceIdResultIntlRequest req)
        {
            return InternalRequestAsync<GetFaceIdResultIntlResponse>(req, "GetFaceIdResultIntl");
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding SDK token after the identity verification process is completed. The SDK token is valid for 72 hours (72*3600s) after generation and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdResultIntlRequest"/></param>
        /// <returns><see cref="GetFaceIdResultIntlResponse"/></returns>
        public GetFaceIdResultIntlResponse GetFaceIdResultIntlSync(GetFaceIdResultIntlRequest req)
        {
            return InternalRequestAsync<GetFaceIdResultIntlResponse>(req, "GetFaceIdResultIntl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to apply for an SDK token before calling the selfie verification SDK each time. The SDK token is used throughout the eKYC process and to get the verification result after the verification is completed. A token is valid for one eKYC process only.
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenIntlRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenIntlResponse"/></returns>
        public Task<GetFaceIdTokenIntlResponse> GetFaceIdTokenIntl(GetFaceIdTokenIntlRequest req)
        {
            return InternalRequestAsync<GetFaceIdTokenIntlResponse>(req, "GetFaceIdTokenIntl");
        }

        /// <summary>
        /// This API is used to apply for an SDK token before calling the selfie verification SDK each time. The SDK token is used throughout the eKYC process and to get the verification result after the verification is completed. A token is valid for one eKYC process only.
        /// </summary>
        /// <param name="req"><see cref="GetFaceIdTokenIntlRequest"/></param>
        /// <returns><see cref="GetFaceIdTokenIntlResponse"/></returns>
        public GetFaceIdTokenIntlResponse GetFaceIdTokenIntlSync(GetFaceIdTokenIntlRequest req)
        {
            return InternalRequestAsync<GetFaceIdTokenIntlResponse>(req, "GetFaceIdTokenIntl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token (SdkToken) after the liveness detection is completed. The token is valid for two hours after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetLivenessResultRequest"/></param>
        /// <returns><see cref="GetLivenessResultResponse"/></returns>
        public Task<GetLivenessResultResponse> GetLivenessResult(GetLivenessResultRequest req)
        {
            return InternalRequestAsync<GetLivenessResultResponse>(req, "GetLivenessResult");
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token (SdkToken) after the liveness detection is completed. The token is valid for two hours after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetLivenessResultRequest"/></param>
        /// <returns><see cref="GetLivenessResultResponse"/></returns>
        public GetLivenessResultResponse GetLivenessResultSync(GetLivenessResultRequest req)
        {
            return InternalRequestAsync<GetLivenessResultResponse>(req, "GetLivenessResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token after the SDK-based verification is completed. The token is valid for three days after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public Task<GetSdkVerificationResultResponse> GetSdkVerificationResult(GetSdkVerificationResultRequest req)
        {
            return InternalRequestAsync<GetSdkVerificationResultResponse>(req, "GetSdkVerificationResult");
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding token after the SDK-based verification is completed. The token is valid for three days after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetSdkVerificationResultRequest"/></param>
        /// <returns><see cref="GetSdkVerificationResultResponse"/></returns>
        public GetSdkVerificationResultResponse GetSdkVerificationResultSync(GetSdkVerificationResultRequest req)
        {
            return InternalRequestAsync<GetSdkVerificationResultResponse>(req, "GetSdkVerificationResult")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding BizToken after the web-based verification is completed. The token is valid for three days (259,200s) after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetWebVerificationResultIntlRequest"/></param>
        /// <returns><see cref="GetWebVerificationResultIntlResponse"/></returns>
        public Task<GetWebVerificationResultIntlResponse> GetWebVerificationResultIntl(GetWebVerificationResultIntlRequest req)
        {
            return InternalRequestAsync<GetWebVerificationResultIntlResponse>(req, "GetWebVerificationResultIntl");
        }

        /// <summary>
        /// This API is used to get the verification result with the corresponding BizToken after the web-based verification is completed. The token is valid for three days (259,200s) after issuance and can be called multiple times.
        /// </summary>
        /// <param name="req"><see cref="GetWebVerificationResultIntlRequest"/></param>
        /// <returns><see cref="GetWebVerificationResultIntlResponse"/></returns>
        public GetWebVerificationResultIntlResponse GetWebVerificationResultIntlSync(GetWebVerificationResultIntlRequest req)
        {
            return InternalRequestAsync<GetWebVerificationResultIntlResponse>(req, "GetWebVerificationResultIntl")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pass in a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// This API on the legacy version will continue to serve existing users but will be unavailable to new users. We recommend you use `VideoLivenessCompare` for better service quality.
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public Task<LivenessCompareResponse> LivenessCompare(LivenessCompareRequest req)
        {
            return InternalRequestAsync<LivenessCompareResponse>(req, "LivenessCompare");
        }

        /// <summary>
        /// This API is used to pass in a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// This API on the legacy version will continue to serve existing users but will be unavailable to new users. We recommend you use `VideoLivenessCompare` for better service quality.
        /// </summary>
        /// <param name="req"><see cref="LivenessCompareRequest"/></param>
        /// <returns><see cref="LivenessCompareResponse"/></returns>
        public LivenessCompareResponse LivenessCompareSync(LivenessCompareRequest req)
        {
            return InternalRequestAsync<LivenessCompareResponse>(req, "LivenessCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to pass in URLs of a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// </summary>
        /// <param name="req"><see cref="VideoLivenessCompareRequest"/></param>
        /// <returns><see cref="VideoLivenessCompareResponse"/></returns>
        public Task<VideoLivenessCompareResponse> VideoLivenessCompare(VideoLivenessCompareRequest req)
        {
            return InternalRequestAsync<VideoLivenessCompareResponse>(req, "VideoLivenessCompare");
        }

        /// <summary>
        /// This API is used to pass in URLs of a video and a photo, determine whether the person in the video is real, and if yes, then determine whether the person in the video is the same as that in the photo.
        /// </summary>
        /// <param name="req"><see cref="VideoLivenessCompareRequest"/></param>
        /// <returns><see cref="VideoLivenessCompareResponse"/></returns>
        public VideoLivenessCompareResponse VideoLivenessCompareSync(VideoLivenessCompareRequest req)
        {
            return InternalRequestAsync<VideoLivenessCompareResponse>(req, "VideoLivenessCompare")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
