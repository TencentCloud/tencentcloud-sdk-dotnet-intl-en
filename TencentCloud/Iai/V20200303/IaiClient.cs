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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to perform facial feature localization (aka facial keypoint localization) on a given image and calculate 90 facial keypoints that make up the contour of the face, including eyebrows (8 points on the left and 8 on the right), eyes (8 points on the left and 8 on the right), nose (13 points), mouth (22 points), face contour (21 points), and eyeballs or pupils (2 points).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="AnalyzeFaceRequest"/></param>
        /// <returns><see cref="AnalyzeFaceResponse"/></returns>
        public async Task<AnalyzeFaceResponse> AnalyzeFace(AnalyzeFaceRequest req)
        {
             JsonResponseModel<AnalyzeFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AnalyzeFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<AnalyzeFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AnalyzeFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check a specified group for suspected duplicate persons and list their information.
        /// 
        /// You can use this API to check for duplicate persons in one group so as to avoid situations where the same person has multiple roles in the group. You can also use it to check for duplicate persons across multiple groups to see whether the same person exists in multiple groups at the same time.
        /// 
        /// Duplicate check across algorithm model versions is not supported. Currently, this feature is available only to groups with algorithm model v3.0.
        /// 
        /// >     
        /// - If you perform a duplicate check on the same group again, you need to wait for the last operation to complete, that is, when the `GroupIds` entered in the two requests are the same, if the first request is not completed, the second request will fail.
        /// 
        /// >     
        /// - The status of the group on which the duplicate check is to be performed is that when the duplicate check task really starts, that is, after you initiate the duplicate check request; if your duplicate check task needs to queue up, any addition or deletion operation performed on the group during the queuing will affect the duplicate check result. Tencent Cloud will use the group status when the duplicate check task actually starts. After the task starts, any operation on the group will not affect the task execution; however, you are still recommended not to add/delete persons or faces to/from the group after the task starts.
        /// </summary>
        /// <param name="req"><see cref="CheckSimilarPersonRequest"/></param>
        /// <returns><see cref="CheckSimilarPersonResponse"/></returns>
        public async Task<CheckSimilarPersonResponse> CheckSimilarPerson(CheckSimilarPersonRequest req)
        {
             JsonResponseModel<CheckSimilarPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckSimilarPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSimilarPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to check a specified group for suspected duplicate persons and list their information.
        /// 
        /// You can use this API to check for duplicate persons in one group so as to avoid situations where the same person has multiple roles in the group. You can also use it to check for duplicate persons across multiple groups to see whether the same person exists in multiple groups at the same time.
        /// 
        /// Duplicate check across algorithm model versions is not supported. Currently, this feature is available only to groups with algorithm model v3.0.
        /// 
        /// >     
        /// - If you perform a duplicate check on the same group again, you need to wait for the last operation to complete, that is, when the `GroupIds` entered in the two requests are the same, if the first request is not completed, the second request will fail.
        /// 
        /// >     
        /// - The status of the group on which the duplicate check is to be performed is that when the duplicate check task really starts, that is, after you initiate the duplicate check request; if your duplicate check task needs to queue up, any addition or deletion operation performed on the group during the queuing will affect the duplicate check result. Tencent Cloud will use the group status when the duplicate check task actually starts. After the task starts, any operation on the group will not affect the task execution; however, you are still recommended not to add/delete persons or faces to/from the group after the task starts.
        /// </summary>
        /// <param name="req"><see cref="CheckSimilarPersonRequest"/></param>
        /// <returns><see cref="CheckSimilarPersonResponse"/></returns>
        public CheckSimilarPersonResponse CheckSimilarPersonSync(CheckSimilarPersonRequest req)
        {
             JsonResponseModel<CheckSimilarPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckSimilarPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckSimilarPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to calculate the similarity of faces in two images and return the face similarity score.
        /// 
        /// If you need to judge "whether the person in the image is someone specified" in scenarios such as face login, i.e., checking whether the person in a given image is someone with a known identity, you are recommended to use the [VerifyFace](https://cloud.tencent.com/document/product/867/32806) or [VerifyPerson](https://cloud.tencent.com/document/product/867/38879) API.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CompareFaceRequest"/></param>
        /// <returns><see cref="CompareFaceResponse"/></returns>
        public async Task<CompareFaceResponse> CompareFace(CompareFaceRequest req)
        {
             JsonResponseModel<CompareFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompareFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to calculate the similarity of faces in two images and return the face similarity score.
        /// 
        /// If you need to judge "whether the person in the image is someone specified" in scenarios such as face login, i.e., checking whether the person in a given image is someone with a known identity, you are recommended to use the [VerifyFace](https://cloud.tencent.com/document/product/867/32806) or [VerifyPerson](https://cloud.tencent.com/document/product/867/38879) API.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CompareFaceRequest"/></param>
        /// <returns><see cref="CompareFaceResponse"/></returns>
        public CompareFaceResponse CompareFaceSync(CompareFaceRequest req)
        {
             JsonResponseModel<CompareFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompareFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to copy a person in a group to another group (without copying the description). One person can exist in up to 100 groups at the same time.
        /// >     
        /// - Note: if the version of the algorithm model was 2.0 when the person was created, the copy operation will fail if it is to copy to a group not on algorithm model v2.0.
        /// </summary>
        /// <param name="req"><see cref="CopyPersonRequest"/></param>
        /// <returns><see cref="CopyPersonResponse"/></returns>
        public async Task<CopyPersonResponse> CopyPerson(CopyPersonRequest req)
        {
             JsonResponseModel<CopyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to copy a person in a group to another group (without copying the description). One person can exist in up to 100 groups at the same time.
        /// >     
        /// - Note: if the version of the algorithm model was 2.0 when the person was created, the copy operation will fail if it is to copy to a group not on algorithm model v2.0.
        /// </summary>
        /// <param name="req"><see cref="CopyPersonRequest"/></param>
        /// <returns><see cref="CopyPersonResponse"/></returns>
        public CopyPersonResponse CopyPersonSync(CopyPersonRequest req)
        {
             JsonResponseModel<CopyPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add a set of face images to a person. One person can have up to 5 images. If a person exists in multiple groups, the images will be added to all those groups for the person.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public async Task<CreateFaceResponse> CreateFace(CreateFaceRequest req)
        {
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
        public async Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a person and add face, name, gender, and other related information.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public async Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
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
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the face images of a person. If the person has only one face image, an error will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public async Task<DeleteFaceResponse> DeleteFace(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the face images of a person. If the person has only one face image, an error will be returned.
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public DeleteFaceResponse DeleteFaceSync(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a group and all persons in it. Meanwhile, all face information corresponding to the persons will be deleted. If a person exists in multiple groups at the same time, deleting a group will not delete the person, but the custom description field information in the group will be deleted. Custom description field information in other groups will not be affected.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a group and all persons in it. Meanwhile, all face information corresponding to the persons will be deleted. If a person exists in multiple groups at the same time, deleting a group will not delete the person, but the custom description field information in the group will be deleted. Custom description field information in other groups will not be affected.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a person from all groups. Meanwhile, all face information of the person will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public async Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a person from all groups. Meanwhile, all face information of the person will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public DeletePersonResponse DeletePersonSync(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a person from a specified group. This operation only affects the group. If the person exists only in the group, the person will be deleted, and all face information of the person will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns><see cref="DeletePersonFromGroupResponse"/></returns>
        public async Task<DeletePersonFromGroupResponse> DeletePersonFromGroup(DeletePersonFromGroupRequest req)
        {
             JsonResponseModel<DeletePersonFromGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove a person from a specified group. This operation only affects the group. If the person exists only in the group, the person will be deleted, and all face information of the person will also be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns><see cref="DeletePersonFromGroupResponse"/></returns>
        public DeletePersonFromGroupResponse DeletePersonFromGroupSync(DeletePersonFromGroupRequest req)
        {
             JsonResponseModel<DeletePersonFromGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePersonFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect the position, attributes, and quality information of a face in the given image. The position information includes (x, y, w, h); the face attributes include gender, age, expression, beauty, glass, hair, mask, and pose (pitch, roll, yaw); and the face quality information includes the overall quality score, sharpness, brightness, and completeness.
        /// 
        ///  
        /// The face quality information is mainly used to evaluate the quality of the input face image. When using the Face Recognition service, you are recommended to evaluate the quality of the input face image first to improve the effects of subsequent processing. Application scenarios of this feature include:
        /// 
        /// 1). [Creating](https://cloud.tencent.com/document/product/867/32793)/[Adding](https://cloud.tencent.com/document/product/867/32795) a person in a group: this is to ensure the quality of the face information to facilitate subsequent processing.
        /// 
        /// 2). [Face search](https://cloud.tencent.com/document/product/867/32798): this is to ensure the quality of the input image to quickly find the corresponding person.
        /// 
        /// 3). [Face verification](https://cloud.tencent.com/document/product/867/32806): this is to ensure the quality of the face information to avoid cases where the verification incorrectly fails.
        /// 
        /// 4). [Face fusion](https://cloud.tencent.com/product/facefusion): this is to ensure the quality of the uploaded face images to improve the fusion effect.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DetectFaceRequest"/></param>
        /// <returns><see cref="DetectFaceResponse"/></returns>
        public async Task<DetectFaceResponse> DetectFace(DetectFaceRequest req)
        {
             JsonResponseModel<DetectFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect the position, attributes, and quality information of a face in the given image. The position information includes (x, y, w, h); the face attributes include gender, age, expression, beauty, glass, hair, mask, and pose (pitch, roll, yaw); and the face quality information includes the overall quality score, sharpness, brightness, and completeness.
        /// 
        ///  
        /// The face quality information is mainly used to evaluate the quality of the input face image. When using the Face Recognition service, you are recommended to evaluate the quality of the input face image first to improve the effects of subsequent processing. Application scenarios of this feature include:
        /// 
        /// 1). [Creating](https://cloud.tencent.com/document/product/867/32793)/[Adding](https://cloud.tencent.com/document/product/867/32795) a person in a group: this is to ensure the quality of the face information to facilitate subsequent processing.
        /// 
        /// 2). [Face search](https://cloud.tencent.com/document/product/867/32798): this is to ensure the quality of the input image to quickly find the corresponding person.
        /// 
        /// 3). [Face verification](https://cloud.tencent.com/document/product/867/32806): this is to ensure the quality of the face information to avoid cases where the verification incorrectly fails.
        /// 
        /// 4). [Face fusion](https://cloud.tencent.com/product/facefusion): this is to ensure the quality of the uploaded face images to improve the fusion effect.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// </summary>
        /// <param name="req"><see cref="DetectFaceRequest"/></param>
        /// <returns><see cref="DetectFaceResponse"/></returns>
        public DetectFaceResponse DetectFaceSync(DetectFaceRequest req)
        {
             JsonResponseModel<DetectFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect the liveness of a user with a user-uploaded image. Its difference from video-based liveness detection lies in that the user does not need to speak, shake their head, or wink for detection.
        /// 
        /// Image-based liveness detection is suitable for scenarios where the image is a selfie or the requirement for attack defense is not high. If you have a higher security requirement for liveness detection, please use [Faceid](https://cloud.tencent.com/product/faceid).
        /// 
        /// >     
        /// - The aspect ratio of the image should be close to 3:4 (width:height); otherwise, the score returned for the image will be meaningless. This API is suitable for selfie scenarios, and the score returned in other scenarios will be meaningless.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceRequest"/></param>
        /// <returns><see cref="DetectLiveFaceResponse"/></returns>
        public async Task<DetectLiveFaceResponse> DetectLiveFace(DetectLiveFaceRequest req)
        {
             JsonResponseModel<DetectLiveFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectLiveFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to detect the liveness of a user with a user-uploaded image. Its difference from video-based liveness detection lies in that the user does not need to speak, shake their head, or wink for detection.
        /// 
        /// Image-based liveness detection is suitable for scenarios where the image is a selfie or the requirement for attack defense is not high. If you have a higher security requirement for liveness detection, please use [Faceid](https://cloud.tencent.com/product/faceid).
        /// 
        /// >     
        /// - The aspect ratio of the image should be close to 3:4 (width:height); otherwise, the score returned for the image will be meaningless. This API is suitable for selfie scenarios, and the score returned in other scenarios will be meaningless.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceRequest"/></param>
        /// <returns><see cref="DetectLiveFaceResponse"/></returns>
        public DetectLiveFaceResponse DetectLiveFaceSync(DetectLiveFaceRequest req)
        {
             JsonResponseModel<DetectLiveFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectLiveFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the estimated duration of a duplicate person check task.
        /// 
        /// If the `EndTimestamp` meets your expectations, please initiate the duplicate person check request as soon as possible; otherwise, the task may take more time.
        /// 
        /// If the estimated duration is more than 5 hours, the duplicate person check feature cannot be used.
        /// </summary>
        /// <param name="req"><see cref="EstimateCheckSimilarPersonCostTimeRequest"/></param>
        /// <returns><see cref="EstimateCheckSimilarPersonCostTimeResponse"/></returns>
        public async Task<EstimateCheckSimilarPersonCostTimeResponse> EstimateCheckSimilarPersonCostTime(EstimateCheckSimilarPersonCostTimeRequest req)
        {
             JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EstimateCheckSimilarPersonCostTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the estimated duration of a duplicate person check task.
        /// 
        /// If the `EndTimestamp` meets your expectations, please initiate the duplicate person check request as soon as possible; otherwise, the task may take more time.
        /// 
        /// If the estimated duration is more than 5 hours, the duplicate person check feature cannot be used.
        /// </summary>
        /// <param name="req"><see cref="EstimateCheckSimilarPersonCostTimeRequest"/></param>
        /// <returns><see cref="EstimateCheckSimilarPersonCostTimeResponse"/></returns>
        public EstimateCheckSimilarPersonCostTimeResponse EstimateCheckSimilarPersonCostTimeSync(EstimateCheckSimilarPersonCostTimeRequest req)
        {
             JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EstimateCheckSimilarPersonCostTime");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EstimateCheckSimilarPersonCostTimeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of duplicate person check tasks and sort them in reverse order by task creation time (i.e., the newest one is at the top)
        /// 
        /// Only data in the past year is retained.
        /// </summary>
        /// <param name="req"><see cref="GetCheckSimilarPersonJobIdListRequest"/></param>
        /// <returns><see cref="GetCheckSimilarPersonJobIdListResponse"/></returns>
        public async Task<GetCheckSimilarPersonJobIdListResponse> GetCheckSimilarPersonJobIdList(GetCheckSimilarPersonJobIdListRequest req)
        {
             JsonResponseModel<GetCheckSimilarPersonJobIdListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCheckSimilarPersonJobIdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCheckSimilarPersonJobIdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of duplicate person check tasks and sort them in reverse order by task creation time (i.e., the newest one is at the top)
        /// 
        /// Only data in the past year is retained.
        /// </summary>
        /// <param name="req"><see cref="GetCheckSimilarPersonJobIdListRequest"/></param>
        /// <returns><see cref="GetCheckSimilarPersonJobIdListResponse"/></returns>
        public GetCheckSimilarPersonJobIdListResponse GetCheckSimilarPersonJobIdListSync(GetCheckSimilarPersonJobIdListRequest req)
        {
             JsonResponseModel<GetCheckSimilarPersonJobIdListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCheckSimilarPersonJobIdList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCheckSimilarPersonJobIdListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the group information.
        /// </summary>
        /// <param name="req"><see cref="GetGroupInfoRequest"/></param>
        /// <returns><see cref="GetGroupInfoResponse"/></returns>
        public async Task<GetGroupInfoResponse> GetGroupInfo(GetGroupInfoRequest req)
        {
             JsonResponseModel<GetGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the group information.
        /// </summary>
        /// <param name="req"><see cref="GetGroupInfoRequest"/></param>
        /// <returns><see cref="GetGroupInfoResponse"/></returns>
        public GetGroupInfoResponse GetGroupInfoSync(GetGroupInfoRequest req)
        {
             JsonResponseModel<GetGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of groups.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public async Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of groups.
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including name, gender, face, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns><see cref="GetPersonBaseInfoResponse"/></returns>
        public async Task<GetPersonBaseInfoResponse> GetPersonBaseInfo(GetPersonBaseInfoRequest req)
        {
             JsonResponseModel<GetPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including name, gender, face, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns><see cref="GetPersonBaseInfoResponse"/></returns>
        public GetPersonBaseInfoResponse GetPersonBaseInfoSync(GetPersonBaseInfoRequest req)
        {
             JsonResponseModel<GetPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including group, description, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns><see cref="GetPersonGroupInfoResponse"/></returns>
        public async Task<GetPersonGroupInfoResponse> GetPersonGroupInfo(GetPersonGroupInfoRequest req)
        {
             JsonResponseModel<GetPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specified person, including group, description, etc.
        /// </summary>
        /// <param name="req"><see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns><see cref="GetPersonGroupInfoResponse"/></returns>
        public GetPersonGroupInfoResponse GetPersonGroupInfoSync(GetPersonGroupInfoRequest req)
        {
             JsonResponseModel<GetPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public async Task<GetPersonListResponse> GetPersonList(GetPersonListRequest req)
        {
             JsonResponseModel<GetPersonListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the list of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public GetPersonListResponse GetPersonListSync(GetPersonListRequest req)
        {
             JsonResponseModel<GetPersonListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListNumRequest"/></param>
        /// <returns><see cref="GetPersonListNumResponse"/></returns>
        public async Task<GetPersonListNumResponse> GetPersonListNum(GetPersonListNumRequest req)
        {
             JsonResponseModel<GetPersonListNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonListNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the number of persons in a specified group.
        /// </summary>
        /// <param name="req"><see cref="GetPersonListNumRequest"/></param>
        /// <returns><see cref="GetPersonListNumResponse"/></returns>
        public GetPersonListNumResponse GetPersonListNumSync(GetPersonListNumRequest req)
        {
             JsonResponseModel<GetPersonListNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonListNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the result of the `CheckSimilarPerson` API.
        /// </summary>
        /// <param name="req"><see cref="GetSimilarPersonResultRequest"/></param>
        /// <returns><see cref="GetSimilarPersonResultResponse"/></returns>
        public async Task<GetSimilarPersonResultResponse> GetSimilarPersonResult(GetSimilarPersonResultRequest req)
        {
             JsonResponseModel<GetSimilarPersonResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetSimilarPersonResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSimilarPersonResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the result of the `CheckSimilarPerson` API.
        /// </summary>
        /// <param name="req"><see cref="GetSimilarPersonResultRequest"/></param>
        /// <returns><see cref="GetSimilarPersonResultResponse"/></returns>
        public GetSimilarPersonResultResponse GetSimilarPersonResultSync(GetSimilarPersonResultRequest req)
        {
             JsonResponseModel<GetSimilarPersonResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetSimilarPersonResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetSimilarPersonResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the name, tag, and custom description field of a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public async Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
             JsonResponseModel<ModifyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the name, tag, and custom description field of a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
             JsonResponseModel<ModifyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a person, including name, gender, etc. The changes of person name and gender will be synced to all the groups that contain the person.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonBaseInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonBaseInfoResponse"/></returns>
        public async Task<ModifyPersonBaseInfoResponse> ModifyPersonBaseInfo(ModifyPersonBaseInfoRequest req)
        {
             JsonResponseModel<ModifyPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the information of a person, including name, gender, etc. The changes of person name and gender will be synced to all the groups that contain the person.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonBaseInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonBaseInfoResponse"/></returns>
        public ModifyPersonBaseInfoResponse ModifyPersonBaseInfoSync(ModifyPersonBaseInfoRequest req)
        {
             JsonResponseModel<ModifyPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the description of a specified person in a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonGroupInfoResponse"/></returns>
        public async Task<ModifyPersonGroupInfoResponse> ModifyPersonGroupInfo(ModifyPersonGroupInfoRequest req)
        {
             JsonResponseModel<ModifyPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the description of a specified person in a group.
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonGroupInfoResponse"/></returns>
        public ModifyPersonGroupInfoResponse ModifyPersonGroupInfoSync(ModifyPersonGroupInfoRequest req)
        {
             JsonResponseModel<ModifyPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in a descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face of a person as an independent one. By contrast, the [SearchPersons](https://cloud.tencent.com/document/product/867/38881) and [SearchPersonsReturnsByGroup](https://cloud.tencent.com/document/product/867/38880) APIs fuse the features of all faces of a person; for example, if a person has 4 faces, they will fuse the features of the 4 faces and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// 
        /// This API should be used together with the [CreateGroup API](https://cloud.tencent.com/document/product/867/32794).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="SearchFacesRequest"/></param>
        /// <returns><see cref="SearchFacesResponse"/></returns>
        public async Task<SearchFacesResponse> SearchFaces(SearchFacesRequest req)
        {
             JsonResponseModel<SearchFacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in a descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face of a person as an independent one. By contrast, the [SearchPersons](https://cloud.tencent.com/document/product/867/38881) and [SearchPersonsReturnsByGroup](https://cloud.tencent.com/document/product/867/38880) APIs fuse the features of all faces of a person; for example, if a person has 4 faces, they will fuse the features of the 4 faces and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// 
        /// This API should be used together with the [CreateGroup API](https://cloud.tencent.com/document/product/867/32794).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="SearchFacesRequest"/></param>
        /// <returns><see cref="SearchFacesResponse"/></returns>
        public SearchFacesResponse SearchFacesSync(SearchFacesRequest req)
        {
             JsonResponseModel<SearchFacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in a descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face of a person as an independent one. By contrast, the [SearchPersons](https://cloud.tencent.com/document/product/867/38881) and [SearchPersonsReturnsByGroup](https://cloud.tencent.com/document/product/867/38880) APIs fuse the features of all faces of a person; for example, if a person has 4 faces, they will fuse the features of the 4 faces and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// This API should be used together with the [CreateGroup API](https://cloud.tencent.com/document/product/867/32794).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// </summary>
        /// <param name="req"><see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchFacesReturnsByGroupResponse"/></returns>
        public async Task<SearchFacesReturnsByGroupResponse> SearchFacesReturnsByGroup(SearchFacesReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchFacesReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFacesReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in a descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API recognizes each face of a person as an independent one. By contrast, the [SearchPersons](https://cloud.tencent.com/document/product/867/38881) and [SearchPersonsReturnsByGroup](https://cloud.tencent.com/document/product/867/38880) APIs fuse the features of all faces of a person; for example, if a person has 4 faces, they will fuse the features of the 4 faces and generate the summarized facial features of the person to make the search more accurate.
        /// 
        /// This API should be used together with the [CreateGroup API](https://cloud.tencent.com/document/product/867/32794).
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// 
        /// </summary>
        /// <param name="req"><see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchFacesReturnsByGroupResponse"/></returns>
        public SearchFacesReturnsByGroupResponse SearchFacesReturnsByGroupSync(SearchFacesReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchFacesReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFacesReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in a descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://cloud.tencent.com/document/product/867/32798) and [SearchFacesReturnsByGroup](https://cloud.tencent.com/document/product/867/38882) APIs recognize each face of a person as an independent one for search.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsRequest"/></param>
        /// <returns><see cref="SearchPersonsResponse"/></returns>
        public async Task<SearchPersonsResponse> SearchPersons(SearchPersonsRequest req)
        {
             JsonResponseModel<SearchPersonsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image and rank the similarity in a descending order.
        /// 
        /// Up to 10 faces in an image can be recognized at a time, and up to 100 groups can be searched in at a time.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://cloud.tencent.com/document/product/867/32798) and [SearchFacesReturnsByGroup](https://cloud.tencent.com/document/product/867/38882) APIs recognize each face of a person as an independent one for search.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsRequest"/></param>
        /// <returns><see cref="SearchPersonsResponse"/></returns>
        public SearchPersonsResponse SearchPersonsSync(SearchPersonsRequest req)
        {
             JsonResponseModel<SearchPersonsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in a descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://cloud.tencent.com/document/product/867/32798) and [SearchFacesReturnsByGroup](https://cloud.tencent.com/document/product/867/38882) APIs recognize each face of a person as an independent one for search.
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchPersonsReturnsByGroupResponse"/></returns>
        public async Task<SearchPersonsReturnsByGroupResponse> SearchPersonsReturnsByGroup(SearchPersonsReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchPersonsReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchPersonsReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to recognize top K persons in one or more groups who are similar to the person in a given image, display the results **by group**, and rank the similarity within each group in a descending order.
        /// 
        /// Up to 10 faces in the image can be recognized at a time, and cross-group search is supported.
        /// 
        /// The maximum number of faces in a group that can be searched for at a time is subject to the group's algorithm model version (`FaceModelVersion`), which is 1 million for v2.0 or 3 million for v3.0.
        /// 
        /// This API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person search (i.e., judging whether the face image to be recognized is of a specified person) more accurate. By contrast, the [SearchFaces](https://cloud.tencent.com/document/product/867/32798) and [SearchFacesReturnsByGroup](https://cloud.tencent.com/document/product/867/38882) APIs recognize each face of a person as an independent one for search.
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchPersonsReturnsByGroupResponse"/></returns>
        public SearchPersonsReturnsByGroupResponse SearchPersonsReturnsByGroupSync(SearchPersonsReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchPersonsReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchPersonsReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [CreateGroup](https://cloud.tencent.com/document/product/867/32794). 
        /// 
        /// Unlike the [CompareFace](https://cloud.tencent.com/document/product/867/32802) API that is used to judge the similarity between two faces, this API is used to judge "whether the person in the image is someone specified" whose information is stored in a group. This "someone" may have multiple face images.
        /// 
        /// This API recognizes each face of a person as an independent one. By contrast, the [VerifyPerson](https://cloud.tencent.com/document/product/867/38879) API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="VerifyFaceRequest"/></param>
        /// <returns><see cref="VerifyFaceResponse"/></returns>
        public async Task<VerifyFaceResponse> VerifyFace(VerifyFaceRequest req)
        {
             JsonResponseModel<VerifyFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [CreateGroup](https://cloud.tencent.com/document/product/867/32794). 
        /// 
        /// Unlike the [CompareFace](https://cloud.tencent.com/document/product/867/32802) API that is used to judge the similarity between two faces, this API is used to judge "whether the person in the image is someone specified" whose information is stored in a group. This "someone" may have multiple face images.
        /// 
        /// This API recognizes each face of a person as an independent one. By contrast, the [VerifyPerson](https://cloud.tencent.com/document/product/867/38879) API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// </summary>
        /// <param name="req"><see cref="VerifyFaceRequest"/></param>
        /// <returns><see cref="VerifyFaceResponse"/></returns>
        public VerifyFaceResponse VerifyFaceSync(VerifyFaceRequest req)
        {
             JsonResponseModel<VerifyFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [CreateGroup](https://cloud.tencent.com/document/product/867/32794).
        /// This API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        ///  Unlike the `CompareFace` API that is used to judge the similarity between two faces, this API is used to judge "whether the person in the image is someone specified" whose information is stored in a group. This "someone" may have multiple face images.
        /// 
        /// 
        /// >     
        /// - Please use the signature algorithm v3 to calculate the signature in the common parameters, that is, set the `SignatureMethod` parameter to `TC3-HMAC-SHA256`.
        /// - This feature is available only to groups whose algorithm model version (`FaceModelVersion`) is 3.0.
        /// </summary>
        /// <param name="req"><see cref="VerifyPersonRequest"/></param>
        /// <returns><see cref="VerifyPersonResponse"/></returns>
        public async Task<VerifyPersonResponse> VerifyPerson(VerifyPersonRequest req)
        {
             JsonResponseModel<VerifyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to judge whether a person in an image corresponds to a given `PersonId`. For more information on `PersonId`, please see [CreateGroup](https://cloud.tencent.com/document/product/867/32794).
        /// This API fuses the features of all faces of a person; for example, if a person has 4 faces, it will fuse the features of the 4 faces and generate the summarized facial features of the person to make the person verification (i.e., judging whether the face image to be recognized is of a specified person) more accurate.
        /// 
        ///  Unlike the `CompareFace` API that is used to judge the similarity between two faces, this API is used to judge "whether the person in the image is someone specified" whose information is stored in a group. This "someone" may have multiple face images.
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
             JsonResponseModel<VerifyPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
