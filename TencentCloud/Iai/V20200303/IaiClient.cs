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

namespace TencentCloud.Iai.V20200303
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iai.V20200303.Models;

   public class IaiClient : AbstractClient{

       private const string endpoint = "iai.tencentcloudapi.com";
       private const string version = "2020-03-03";
       private const string sdkVersion = "SDK_NET_3.0.1084";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to perform facial feature localization (aka facial keypoint localization) on a given image and calculate 90 facial keypoints that make up the contour of the face, including eyebrows (8 points on the left and 8 on the right), eyes (8 points on the left and 8 on the right), nose (13 points), mouth (22 points), face contour (21 points), and eyeballs or pupils (2 points).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="AnalyzeFaceRequest"/></param>
        /// <returns><see cref="AnalyzeFaceResponse"/></returns>
        public Task<AnalyzeFaceResponse> AnalyzeFace(AnalyzeFaceRequest req)
        {
            return InternalRequestAsync<AnalyzeFaceResponse>(req, "AnalyzeFace");
        }

        /// <summary>
        /// This API is used to perform facial feature localization (aka facial keypoint localization) on a given image and calculate 90 facial keypoints that make up the contour of the face, including eyebrows (8 points on the left and 8 on the right), eyes (8 points on the left and 8 on the right), nose (13 points), mouth (22 points), face contour (21 points), and eyeballs or pupils (2 points).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="AnalyzeFaceRequest"/></param>
        /// <returns><see cref="AnalyzeFaceResponse"/></returns>
        public AnalyzeFaceResponse AnalyzeFaceSync(AnalyzeFaceRequest req)
        {
            return InternalRequestAsync<AnalyzeFaceResponse>(req, "AnalyzeFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to calculate the similarity of faces in two images and return the face similarity score.
        /// 
        /// If you need to judge "whether the person in the image is someone specified" in scenarios such as face login, i.e., checking whether the person in a given image is someone with a known identity, we recommend using the [VerifyFace](https://intl.cloud.tencent.com/document/product/867/44983?from_cn_redirect=1) or [VerifyPerson](https://intl.cloud.tencent.com/document/product/867/44982?from_cn_redirect=1) API.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CompareFaceRequest"/></param>
        /// <returns><see cref="CompareFaceResponse"/></returns>
        public Task<CompareFaceResponse> CompareFace(CompareFaceRequest req)
        {
            return InternalRequestAsync<CompareFaceResponse>(req, "CompareFace");
        }

        /// <summary>
        /// This API is used to calculate the similarity of faces in two images and return the face similarity score.
        /// 
        /// If you need to judge "whether the person in the image is someone specified" in scenarios such as face login, i.e., checking whether the person in a given image is someone with a known identity, we recommend using the [VerifyFace](https://intl.cloud.tencent.com/document/product/867/44983?from_cn_redirect=1) or [VerifyPerson](https://intl.cloud.tencent.com/document/product/867/44982?from_cn_redirect=1) API.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CompareFaceRequest"/></param>
        /// <returns><see cref="CompareFaceResponse"/></returns>
        public CompareFaceResponse CompareFaceSync(CompareFaceRequest req)
        {
            return InternalRequestAsync<CompareFaceResponse>(req, "CompareFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to copy a person in a group to another group (without copying the description). One person can exist in up to 100 groups at the same time.
        /// >     
        /// - Note: in the case that the version of the algorithm model was 2.0 when the person was created, the copy operation will fail if the target group is not of algorithm model 2.0.
        /// </summary>
        /// <param name="req"><see cref="CopyPersonRequest"/></param>
        /// <returns><see cref="CopyPersonResponse"/></returns>
        public Task<CopyPersonResponse> CopyPerson(CopyPersonRequest req)
        {
            return InternalRequestAsync<CopyPersonResponse>(req, "CopyPerson");
        }

        /// <summary>
        /// This API is used to copy a person in a group to another group (without copying the description). One person can exist in up to 100 groups at the same time.
        /// >     
        /// - Note: in the case that the version of the algorithm model was 2.0 when the person was created, the copy operation will fail if the target group is not of algorithm model 2.0.
        /// </summary>
        /// <param name="req"><see cref="CopyPersonRequest"/></param>
        /// <returns><see cref="CopyPersonResponse"/></returns>
        public CopyPersonResponse CopyPersonSync(CopyPersonRequest req)
        {
            return InternalRequestAsync<CopyPersonResponse>(req, "CopyPerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add a set of face images to a person. One person can have up to 5 images. If a person exists in multiple groups, the images will be added to all those groups for the person.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public Task<CreateFaceResponse> CreateFace(CreateFaceRequest req)
        {
            return InternalRequestAsync<CreateFaceResponse>(req, "CreateFace");
        }

        /// <summary>
        /// This API is used to add a set of face images to a person. One person can have up to 5 images. If a person exists in multiple groups, the images will be added to all those groups for the person.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public CreateFaceResponse CreateFaceSync(CreateFaceRequest req)
        {
            return InternalRequestAsync<CreateFaceResponse>(req, "CreateFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an empty group. If the group already exists, an error will be returned.
        /// Custom description fields can be created as needed to describe persons in the group.
        /// 
        /// A maximum of 100,000 groups or 50 million faces can be created under one `APPID`.
        /// 
        /// The maximum number of faces that can be included in one group varies by algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup");
        }

        /// <summary>
        /// This API is used to create an empty group. If the group already exists, an error will be returned.
        /// Custom description fields can be created as needed to describe persons in the group.
        /// 
        /// A maximum of 100,000 groups or 50 million faces can be created under one `APPID`.
        /// 
        /// The maximum number of faces that can be included in one group varies by algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupResponse>(req, "CreateGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a person and add face, name, gender, and other related information.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
            return InternalRequestAsync<CreatePersonResponse>(req, "CreatePerson");
        }

        /// <summary>
        /// This API is used to create a person and add face, name, gender, and other related information.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public CreatePersonResponse CreatePersonSync(CreatePersonRequest req)
        {
            return InternalRequestAsync<CreatePersonResponse>(req, "CreatePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the face images of a person. If the person has only one face image, an error will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public Task<DeleteFaceResponse> DeleteFace(DeleteFaceRequest req)
        {
            return InternalRequestAsync<DeleteFaceResponse>(req, "DeleteFace");
        }

        /// <summary>
        /// This API is used to delete the face images of a person. If the person has only one face image, an error will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public DeleteFaceResponse DeleteFaceSync(DeleteFaceRequest req)
        {
            return InternalRequestAsync<DeleteFaceResponse>(req, "DeleteFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a group and all persons in it. Meanwhile, all face information corresponding to the persons will be deleted. If a person exists in multiple groups at the same time, deleting a group will not delete the person, but the custom description field information in the group will be deleted. Custom description field information in other groups will not be affected.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// This API is used to delete a group and all persons in it. Meanwhile, all face information corresponding to the persons will be deleted. If a person exists in multiple groups at the same time, deleting a group will not delete the person, but the custom description field information in the group will be deleted. Custom description field information in other groups will not be affected.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a person from all groups. Meanwhile, all face information of the person will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
            return InternalRequestAsync<DeletePersonResponse>(req, "DeletePerson");
        }

        /// <summary>
        /// This API is used to delete a person from all groups. Meanwhile, all face information of the person will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public DeletePersonResponse DeletePersonSync(DeletePersonRequest req)
        {
            return InternalRequestAsync<DeletePersonResponse>(req, "DeletePerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a person from a specified group. This operation only affects the group. If the person exists only in the group, the person will be deleted, and all face information of the person will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns><see cref="DeletePersonFromGroupResponse"/></returns>
        public Task<DeletePersonFromGroupResponse> DeletePersonFromGroup(DeletePersonFromGroupRequest req)
        {
            return InternalRequestAsync<DeletePersonFromGroupResponse>(req, "DeletePersonFromGroup");
        }

        /// <summary>
        /// This API is used to remove a person from a specified group. This operation only affects the group. If the person exists only in the group, the person will be deleted, and all face information of the person will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns><see cref="DeletePersonFromGroupResponse"/></returns>
        public DeletePersonFromGroupResponse DeletePersonFromGroupSync(DeletePersonFromGroupRequest req)
        {
            return InternalRequestAsync<DeletePersonFromGroupResponse>(req, "DeletePersonFromGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect the position, attributes, and quality information of a face in the given image. The position information includes (x, y, w, h); the face attributes include gender, age, expression, beauty, glass, hair, mask, and pose (pitch, roll, yaw); and the face quality information includes the overall quality score, sharpness, brightness, and completeness.
        /// 
        ///  
        /// The face quality information is mainly used to evaluate the quality of the input face image. When using the Face Recognition service, we recommend evaluating the quality of the input face image first to improve the effects of subsequent processing. Application scenarios of this feature include:
        /// 
        /// 1. [Creating](https://intl.cloud.tencent.com/document/product/867/45014?from_cn_redirect=1)/[Adding](https://intl.cloud.tencent.com/document/product/867/45016?from_cn_redirect=1) a person in a group: this is to ensure the quality of the face information to facilitate subsequent processing.
        /// 
        /// 2. [Face search](https://intl.cloud.tencent.com/document/product/867/44994?from_cn_redirect=1): this is to ensure the quality of the input image to quickly find the corresponding person.
        /// 
        /// 3. [Face verification](https://intl.cloud.tencent.com/document/product/867/44983?from_cn_redirect=1): this is to ensure the quality of the face information to avoid cases where the verification incorrectly fails.
        /// 
        /// 4. Face fusion: this is to ensure the quality of the uploaded face images to improve the fusion effect.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DetectFaceRequest"/></param>
        /// <returns><see cref="DetectFaceResponse"/></returns>
        public Task<DetectFaceResponse> DetectFace(DetectFaceRequest req)
        {
            return InternalRequestAsync<DetectFaceResponse>(req, "DetectFace");
        }

        /// <summary>
        /// This API is used to detect the position, attributes, and quality information of a face in the given image. The position information includes (x, y, w, h); the face attributes include gender, age, expression, beauty, glass, hair, mask, and pose (pitch, roll, yaw); and the face quality information includes the overall quality score, sharpness, brightness, and completeness.
        /// 
        ///  
        /// The face quality information is mainly used to evaluate the quality of the input face image. When using the Face Recognition service, we recommend evaluating the quality of the input face image first to improve the effects of subsequent processing. Application scenarios of this feature include:
        /// 
        /// 1. [Creating](https://intl.cloud.tencent.com/document/product/867/45014?from_cn_redirect=1)/[Adding](https://intl.cloud.tencent.com/document/product/867/45016?from_cn_redirect=1) a person in a group: this is to ensure the quality of the face information to facilitate subsequent processing.
        /// 
        /// 2. [Face search](https://intl.cloud.tencent.com/document/product/867/44994?from_cn_redirect=1): this is to ensure the quality of the input image to quickly find the corresponding person.
        /// 
        /// 3. [Face verification](https://intl.cloud.tencent.com/document/product/867/44983?from_cn_redirect=1): this is to ensure the quality of the face information to avoid cases where the verification incorrectly fails.
        /// 
        /// 4. Face fusion: this is to ensure the quality of the uploaded face images to improve the fusion effect.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DetectFaceRequest"/></param>
        /// <returns><see cref="DetectFaceResponse"/></returns>
        public DetectFaceResponse DetectFaceSync(DetectFaceRequest req)
        {
            return InternalRequestAsync<DetectFaceResponse>(req, "DetectFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect the position, attributes, and quality information of a face in the given image. The position information includes (x, y, w, h); the face attributes include gender, age, expression, beauty, glass, hair, mask, and pose (pitch, roll, yaw); and the face quality information includes the overall quality score, sharpness, brightness, and completeness.
        /// 
        ///  
        /// The face quality information is mainly used to evaluate the quality of the input face image. When using the Face Recognition service, we recommend evaluating the quality of the input face image first to improve the effects of subsequent processing. Application scenarios of this feature include:
        /// 
        /// 1. [Creating](https://intl.cloud.tencent.com/document/api/1059/36964)/[Adding](https://intl.cloud.tencent.com/document/api/1059/36966) a person in a group: This is to ensure the quality of the face information to facilitate subsequent processing.
        /// 
        /// 2. [Face search](https://intl.cloud.tencent.com/document/api/1059/36977): This is to ensure the quality of the input image to quickly find the corresponding person.
        /// 
        /// 3. [Face verification](https://intl.cloud.tencent.com/document/api/1059/36972): This is to ensure the quality of the face information to avoid cases where the verification fails unexpectedly.
        /// 
        /// 4. Face fusion: This is to ensure the quality of the uploaded face images to improve the fusion effect.
        /// 
        /// >     
        /// - This API is an upgrade of [DetectFace](https://intl.cloud.tencent.com/document/api/1059/36979); specifically:
        /// 1. This API can be used to specify the face attributes that need to be computed and returned, which avoids ineffective computation and reduces time consumption.
        /// 2. This API supports more detailed attribute items and will continue providing new features in the future.
        /// Use this API for corresponding face detection and attribute analysis.
        /// 
        /// >     
        /// - Use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="DetectFaceAttributesRequest"/></param>
        /// <returns><see cref="DetectFaceAttributesResponse"/></returns>
        public Task<DetectFaceAttributesResponse> DetectFaceAttributes(DetectFaceAttributesRequest req)
        {
            return InternalRequestAsync<DetectFaceAttributesResponse>(req, "DetectFaceAttributes");
        }

        /// <summary>
        /// This API is used to detect the position, attributes, and quality information of a face in the given image. The position information includes (x, y, w, h); the face attributes include gender, age, expression, beauty, glass, hair, mask, and pose (pitch, roll, yaw); and the face quality information includes the overall quality score, sharpness, brightness, and completeness.
        /// 
        ///  
        /// The face quality information is mainly used to evaluate the quality of the input face image. When using the Face Recognition service, we recommend evaluating the quality of the input face image first to improve the effects of subsequent processing. Application scenarios of this feature include:
        /// 
        /// 1. [Creating](https://intl.cloud.tencent.com/document/api/1059/36964)/[Adding](https://intl.cloud.tencent.com/document/api/1059/36966) a person in a group: This is to ensure the quality of the face information to facilitate subsequent processing.
        /// 
        /// 2. [Face search](https://intl.cloud.tencent.com/document/api/1059/36977): This is to ensure the quality of the input image to quickly find the corresponding person.
        /// 
        /// 3. [Face verification](https://intl.cloud.tencent.com/document/api/1059/36972): This is to ensure the quality of the face information to avoid cases where the verification fails unexpectedly.
        /// 
        /// 4. Face fusion: This is to ensure the quality of the uploaded face images to improve the fusion effect.
        /// 
        /// >     
        /// - This API is an upgrade of [DetectFace](https://intl.cloud.tencent.com/document/api/1059/36979); specifically:
        /// 1. This API can be used to specify the face attributes that need to be computed and returned, which avoids ineffective computation and reduces time consumption.
        /// 2. This API supports more detailed attribute items and will continue providing new features in the future.
        /// Use this API for corresponding face detection and attribute analysis.
        /// 
        /// >     
        /// - Use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="DetectFaceAttributesRequest"/></param>
        /// <returns><see cref="DetectFaceAttributesResponse"/></returns>
        public DetectFaceAttributesResponse DetectFaceAttributesSync(DetectFaceAttributesRequest req)
        {
            return InternalRequestAsync<DetectFaceAttributesResponse>(req, "DetectFaceAttributes")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Compare the faces in the two pictures for similarity and return the face similarity score. If you need to determine "whether this person is someone", that is, to verify whether the person in a picture is someone with a known identity, such as a common face login scenario, it is recommended to use [VerifyFace] (https://www.tencentcloud.com/document/product/1059/36972) or [VerifyPerson] (https://www.tencentcloud.com/document/product/1059/36971) inferface. 
        /// Please use the V3 version for the signature method in the public parameters, that is, configure the SignatureMethod parameter to TC3-HMAC-SHA256
        /// </summary>
        /// <param name="req"><see cref="DetectFaceSimilarityRequest"/></param>
        /// <returns><see cref="DetectFaceSimilarityResponse"/></returns>
        public Task<DetectFaceSimilarityResponse> DetectFaceSimilarity(DetectFaceSimilarityRequest req)
        {
            return InternalRequestAsync<DetectFaceSimilarityResponse>(req, "DetectFaceSimilarity");
        }

        /// <summary>
        /// Compare the faces in the two pictures for similarity and return the face similarity score. If you need to determine "whether this person is someone", that is, to verify whether the person in a picture is someone with a known identity, such as a common face login scenario, it is recommended to use [VerifyFace] (https://www.tencentcloud.com/document/product/1059/36972) or [VerifyPerson] (https://www.tencentcloud.com/document/product/1059/36971) inferface. 
        /// Please use the V3 version for the signature method in the public parameters, that is, configure the SignatureMethod parameter to TC3-HMAC-SHA256
        /// </summary>
        /// <param name="req"><see cref="DetectFaceSimilarityRequest"/></param>
        /// <returns><see cref="DetectFaceSimilarityResponse"/></returns>
        public DetectFaceSimilarityResponse DetectFaceSimilaritySync(DetectFaceSimilarityRequest req)
        {
            return InternalRequestAsync<DetectFaceSimilarityResponse>(req, "DetectFaceSimilarity")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect the liveness of a face in a static image uploaded by a user. Compared with dynamic liveness detection, static liveness detection does not require moving lips, shaking head, or blinking for recognition.
        /// 
        /// Image-based liveness detection is suitable for scenarios where the image is a selfie or the requirement for attack defense is not high. If you have a higher security requirement for liveness detection, please use [FaceID](https://intl.cloud.tencent.com/product/faceid?from_cn_redirect=1).
        /// 
        /// >     
        /// - The aspect ratio of the image should be close to 3:4 (width:height); otherwise, the score returned for the image will be meaningless. This API is suitable for selfie scenarios, and the score returned in other scenarios will be meaningless.
        /// 
        /// >
        /// - During the process, please directly face the camera and keep a suitable distance to completely display your face in the recognition frame. During the recognition, keep your device still and fully show your face. You are advised to perform the detection in an environment with appropriate light and without filters.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceRequest"/></param>
        /// <returns><see cref="DetectLiveFaceResponse"/></returns>
        public Task<DetectLiveFaceResponse> DetectLiveFace(DetectLiveFaceRequest req)
        {
            return InternalRequestAsync<DetectLiveFaceResponse>(req, "DetectLiveFace");
        }

        /// <summary>
        /// This API is used to detect the liveness of a face in a static image uploaded by a user. Compared with dynamic liveness detection, static liveness detection does not require moving lips, shaking head, or blinking for recognition.
        /// 
        /// Image-based liveness detection is suitable for scenarios where the image is a selfie or the requirement for attack defense is not high. If you have a higher security requirement for liveness detection, please use [FaceID](https://intl.cloud.tencent.com/product/faceid?from_cn_redirect=1).
        /// 
        /// >     
        /// - The aspect ratio of the image should be close to 3:4 (width:height); otherwise, the score returned for the image will be meaningless. This API is suitable for selfie scenarios, and the score returned in other scenarios will be meaningless.
        /// 
        /// >
        /// - During the process, please directly face the camera and keep a suitable distance to completely display your face in the recognition frame. During the recognition, keep your device still and fully show your face. You are advised to perform the detection in an environment with appropriate light and without filters.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceRequest"/></param>
        /// <returns><see cref="DetectLiveFaceResponse"/></returns>
        public DetectLiveFaceResponse DetectLiveFaceSync(DetectLiveFaceRequest req)
        {
            return InternalRequestAsync<DetectLiveFaceResponse>(req, "DetectLiveFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to detect the liveness of faces in images uploaded by users and determine whether these images are photographed.
        /// 
        /// Compared with normal Image-based Liveness Detection services, this API enhances the defense capability against attacks from HD screens, printed photos, and 3D masks, as well as improves attack blocking four to five times the competing products, while maintaining high accuracy. It also supports face verification in different use cases, and satisfies the image-based liveness detection needs on mobile or PCs, making it ideal for liveness detection applications in various industries.
        /// 
        /// Pay-as-you-go billing officially started for this API at 00:00, August 1, 2022. For more information, see [Billing Overview](https://intl.cloud.tencent.com/document/product/867/17640?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceAccurateRequest"/></param>
        /// <returns><see cref="DetectLiveFaceAccurateResponse"/></returns>
        public Task<DetectLiveFaceAccurateResponse> DetectLiveFaceAccurate(DetectLiveFaceAccurateRequest req)
        {
            return InternalRequestAsync<DetectLiveFaceAccurateResponse>(req, "DetectLiveFaceAccurate");
        }

        /// <summary>
        /// This API is used to detect the liveness of faces in images uploaded by users and determine whether these images are photographed.
        /// 
        /// Compared with normal Image-based Liveness Detection services, this API enhances the defense capability against attacks from HD screens, printed photos, and 3D masks, as well as improves attack blocking four to five times the competing products, while maintaining high accuracy. It also supports face verification in different use cases, and satisfies the image-based liveness detection needs on mobile or PCs, making it ideal for liveness detection applications in various industries.
        /// 
        /// Pay-as-you-go billing officially started for this API at 00:00, August 1, 2022. For more information, see [Billing Overview](https://intl.cloud.tencent.com/document/product/867/17640?from_cn_redirect=1).
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceAccurateRequest"/></param>
        /// <returns><see cref="DetectLiveFaceAccurateResponse"/></returns>
        public DetectLiveFaceAccurateResponse DetectLiveFaceAccurateSync(DetectLiveFaceAccurateRequest req)
        {
            return InternalRequestAsync<DetectLiveFaceAccurateResponse>(req, "DetectLiveFaceAccurate")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the group information.
        /// </summary>
        /// <param name="req"><see cref="GetGroupInfoRequest"/></param>
        /// <returns><see cref="GetGroupInfoResponse"/></returns>
        public Task<GetGroupInfoResponse> GetGroupInfo(GetGroupInfoRequest req)
        {
            return InternalRequestAsync<GetGroupInfoResponse>(req, "GetGroupInfo");
        }

        /// <summary>
        /// This API is used to get the group information.
        /// </summary>
        /// <param name="req"><see cref="GetGroupInfoRequest"/></param>
        /// <returns><see cref="GetGroupInfoResponse"/></returns>
        public GetGroupInfoResponse GetGroupInfoSync(GetGroupInfoRequest req)
        {
            return InternalRequestAsync<GetGroupInfoResponse>(req, "GetGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of groups.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList");
        }

        /// <summary>
        /// This API is used to get the list of groups.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
            return InternalRequestAsync<GetGroupListResponse>(req, "GetGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including name, gender, face, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns><see cref="GetPersonBaseInfoResponse"/></returns>
        public Task<GetPersonBaseInfoResponse> GetPersonBaseInfo(GetPersonBaseInfoRequest req)
        {
            return InternalRequestAsync<GetPersonBaseInfoResponse>(req, "GetPersonBaseInfo");
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including name, gender, face, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns><see cref="GetPersonBaseInfoResponse"/></returns>
        public GetPersonBaseInfoResponse GetPersonBaseInfoSync(GetPersonBaseInfoRequest req)
        {
            return InternalRequestAsync<GetPersonBaseInfoResponse>(req, "GetPersonBaseInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including group, description, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns><see cref="GetPersonGroupInfoResponse"/></returns>
        public Task<GetPersonGroupInfoResponse> GetPersonGroupInfo(GetPersonGroupInfoRequest req)
        {
            return InternalRequestAsync<GetPersonGroupInfoResponse>(req, "GetPersonGroupInfo");
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including group, description, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns><see cref="GetPersonGroupInfoResponse"/></returns>
        public GetPersonGroupInfoResponse GetPersonGroupInfoSync(GetPersonGroupInfoRequest req)
        {
            return InternalRequestAsync<GetPersonGroupInfoResponse>(req, "GetPersonGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public Task<GetPersonListResponse> GetPersonList(GetPersonListRequest req)
        {
            return InternalRequestAsync<GetPersonListResponse>(req, "GetPersonList");
        }

        /// <summary>
        /// This API is used to get the list of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public GetPersonListResponse GetPersonListSync(GetPersonListRequest req)
        {
            return InternalRequestAsync<GetPersonListResponse>(req, "GetPersonList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the number of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListNumRequest"/></param>
        /// <returns><see cref="GetPersonListNumResponse"/></returns>
        public Task<GetPersonListNumResponse> GetPersonListNum(GetPersonListNumRequest req)
        {
            return InternalRequestAsync<GetPersonListNumResponse>(req, "GetPersonListNum");
        }

        /// <summary>
        /// This API is used to get the number of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListNumRequest"/></param>
        /// <returns><see cref="GetPersonListNumResponse"/></returns>
        public GetPersonListNumResponse GetPersonListNumSync(GetPersonListNumRequest req)
        {
            return InternalRequestAsync<GetPersonListNumResponse>(req, "GetPersonListNum")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the name, tag, and custom description field of a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup");
        }

        /// <summary>
        /// This API is used to modify the name, tag, and custom description field of a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the description of a specified person in a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonGroupInfoResponse"/></returns>
        public Task<ModifyPersonGroupInfoResponse> ModifyPersonGroupInfo(ModifyPersonGroupInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonGroupInfoResponse>(req, "ModifyPersonGroupInfo");
        }

        /// <summary>
        /// This API is used to modify the description of a specified person in a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonGroupInfoResponse"/></returns>
        public ModifyPersonGroupInfoResponse ModifyPersonGroupInfoSync(ModifyPersonGroupInfoRequest req)
        {
            return InternalRequestAsync<ModifyPersonGroupInfoResponse>(req, "ModifyPersonGroupInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the algorithm model version (`FaceModelVersion`) of groups, which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face image of a person as an independent one. By contrast, the [SearchPersons](https://intl.cloud.tencent.com/document/product/867/44992?from_cn_redirect=1) and [SearchPersonsReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44991?from_cn_redirect=1) APIs fuse the features of all face images of a person; for example, if a person has 4 face images, they will fuse the features of the 4 face images and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// 
        /// This API should be used together with [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// 
        /// >     
        /// - You cannot search for groups using different algorithm model versions (`FaceModelVersion`) at a time.
        /// </summary>
        /// <param name="req"><see cref="SearchFacesRequest"/></param>
        /// <returns><see cref="SearchFacesResponse"/></returns>
        public Task<SearchFacesResponse> SearchFaces(SearchFacesRequest req)
        {
            return InternalRequestAsync<SearchFacesResponse>(req, "SearchFaces");
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the algorithm model version (`FaceModelVersion`) of groups, which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face image of a person as an independent one. By contrast, the [SearchPersons](https://intl.cloud.tencent.com/document/product/867/44992?from_cn_redirect=1) and [SearchPersonsReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44991?from_cn_redirect=1) APIs fuse the features of all face images of a person; for example, if a person has 4 face images, they will fuse the features of the 4 face images and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// 
        /// This API should be used together with [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// 
        /// >     
        /// - You cannot search for groups using different algorithm model versions (`FaceModelVersion`) at a time.
        /// </summary>
        /// <param name="req"><see cref="SearchFacesRequest"/></param>
        /// <returns><see cref="SearchFacesResponse"/></returns>
        public SearchFacesResponse SearchFacesSync(SearchFacesRequest req)
        {
            return InternalRequestAsync<SearchFacesResponse>(req, "SearchFaces")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face image of a person as an independent one. By contrast, the [SearchPersons](https://intl.cloud.tencent.com/document/product/867/44992?from_cn_redirect=1) and [SearchPersonsReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44991?from_cn_redirect=1) APIs fuse the features of all face images of a person; for example, if a person has 4 face images, they will fuse the features of the 4 face images and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// This API should be used together with [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// >     
        /// - You cannot search for groups using different algorithm model versions (`FaceModelVersion`) at a time.
        /// </summary>
        /// <param name="req"><see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchFacesReturnsByGroupResponse"/></returns>
        public Task<SearchFacesReturnsByGroupResponse> SearchFacesReturnsByGroup(SearchFacesReturnsByGroupRequest req)
        {
            return InternalRequestAsync<SearchFacesReturnsByGroupResponse>(req, "SearchFacesReturnsByGroup");
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face image of a person as an independent one. By contrast, the [SearchPersons](https://intl.cloud.tencent.com/document/product/867/44992?from_cn_redirect=1) and [SearchPersonsReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44991?from_cn_redirect=1) APIs fuse the features of all face images of a person; for example, if a person has 4 face images, they will fuse the features of the 4 face images and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// This API should be used together with [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// >     
        /// - You cannot search for groups using different algorithm model versions (`FaceModelVersion`) at a time.
        /// </summary>
        /// <param name="req"><see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchFacesReturnsByGroupResponse"/></returns>
        public SearchFacesReturnsByGroupResponse SearchFacesReturnsByGroupSync(SearchFacesReturnsByGroupRequest req)
        {
            return InternalRequestAsync<SearchFacesReturnsByGroupResponse>(req, "SearchFacesReturnsByGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in a descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all face images of a person; for example, if a person has 4 face images, it will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://intl.cloud.tencent.com/document/product/867/44994?from_cn_redirect=1) and [SearchFacesReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44993?from_cn_redirect=1) APIs recognize each face image of a person as an independent one for search.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsRequest"/></param>
        /// <returns><see cref="SearchPersonsResponse"/></returns>
        public Task<SearchPersonsResponse> SearchPersons(SearchPersonsRequest req)
        {
            return InternalRequestAsync<SearchPersonsResponse>(req, "SearchPersons");
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in a descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all face images of a person; for example, if a person has 4 face images, it will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://intl.cloud.tencent.com/document/product/867/44994?from_cn_redirect=1) and [SearchFacesReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44993?from_cn_redirect=1) APIs recognize each face image of a person as an independent one for search.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsRequest"/></param>
        /// <returns><see cref="SearchPersonsResponse"/></returns>
        public SearchPersonsResponse SearchPersonsSync(SearchPersonsRequest req)
        {
            return InternalRequestAsync<SearchPersonsResponse>(req, "SearchPersons")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in a descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all face images of a person; for example, if a person has 4 face images, it will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://intl.cloud.tencent.com/document/product/867/44994?from_cn_redirect=1) and [SearchFacesReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44993?from_cn_redirect=1) APIs recognize each face image of a person as an independent one for search.
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchPersonsReturnsByGroupResponse"/></returns>
        public Task<SearchPersonsReturnsByGroupResponse> SearchPersonsReturnsByGroup(SearchPersonsReturnsByGroupRequest req)
        {
            return InternalRequestAsync<SearchPersonsReturnsByGroupResponse>(req, "SearchPersonsReturnsByGroup");
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in a descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in groups that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all face images of a person; for example, if a person has 4 face images, it will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://intl.cloud.tencent.com/document/product/867/44994?from_cn_redirect=1) and [SearchFacesReturnsByGroup](https://intl.cloud.tencent.com/document/product/867/44993?from_cn_redirect=1) APIs recognize each face image of a person as an independent one for search.
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchPersonsReturnsByGroupResponse"/></returns>
        public SearchPersonsReturnsByGroupResponse SearchPersonsReturnsByGroupSync(SearchPersonsReturnsByGroupRequest req)
        {
            return InternalRequestAsync<SearchPersonsReturnsByGroupResponse>(req, "SearchPersonsReturnsByGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1). 
        /// 
        /// The `VerifyFace` API judges whether a person is someone specified whose information is stored in a group, and there may be multiple face images of "someone". By contrast, the [CompareFace](https://intl.cloud.tencent.com/document/product/867/44987?from_cn_redirect=1) API judges the similarity between two faces.
        /// 
        /// This API recognizes each face image of a person as an independent one. By contrast, the [VerifyPerson](https://intl.cloud.tencent.com/document/product/867/44982?from_cn_redirect=1) API fuses the features of all face images of a person; for example, if a person has 4 face images, the VerifyPerson API will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="VerifyFaceRequest"/></param>
        /// <returns><see cref="VerifyFaceResponse"/></returns>
        public Task<VerifyFaceResponse> VerifyFace(VerifyFaceRequest req)
        {
            return InternalRequestAsync<VerifyFaceResponse>(req, "VerifyFace");
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1). 
        /// 
        /// The `VerifyFace` API judges whether a person is someone specified whose information is stored in a group, and there may be multiple face images of "someone". By contrast, the [CompareFace](https://intl.cloud.tencent.com/document/product/867/44987?from_cn_redirect=1) API judges the similarity between two faces.
        /// 
        /// This API recognizes each face image of a person as an independent one. By contrast, the [VerifyPerson](https://intl.cloud.tencent.com/document/product/867/44982?from_cn_redirect=1) API fuses the features of all face images of a person; for example, if a person has 4 face images, the VerifyPerson API will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the parameter `SignatureMethod` to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="VerifyFaceRequest"/></param>
        /// <returns><see cref="VerifyFaceResponse"/></returns>
        public VerifyFaceResponse VerifyFaceSync(VerifyFaceRequest req)
        {
            return InternalRequestAsync<VerifyFaceResponse>(req, "VerifyFace")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1).
        /// This API fuses the features of all face images of a person; for example, if a person has 4 face images, it will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        ///  The face verification APIs judge whether a person is someone specified whose information is stored in a group, and the "someone" may have multiple face images. By contrast, the face comparison APIs judge the similarity between two faces.
        /// 
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="VerifyPersonRequest"/></param>
        /// <returns><see cref="VerifyPersonResponse"/></returns>
        public Task<VerifyPersonResponse> VerifyPerson(VerifyPersonRequest req)
        {
            return InternalRequestAsync<VerifyPersonResponse>(req, "VerifyPerson");
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [Group Management APIs](https://intl.cloud.tencent.com/document/product/867/45015?from_cn_redirect=1).
        /// This API fuses the features of all face images of a person; for example, if a person has 4 face images, it will fuse the features of the 4 face images and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        ///  The face verification APIs judge whether a person is someone specified whose information is stored in a group, and the "someone" may have multiple face images. By contrast, the face comparison APIs judge the similarity between two faces.
        /// 
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="VerifyPersonRequest"/></param>
        /// <returns><see cref="VerifyPersonResponse"/></returns>
        public VerifyPersonResponse VerifyPersonSync(VerifyPersonRequest req)
        {
            return InternalRequestAsync<VerifyPersonResponse>(req, "VerifyPerson")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
