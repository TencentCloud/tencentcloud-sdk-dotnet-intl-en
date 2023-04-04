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

namespace TencentCloud.Lcic.V20220817
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lcic.V20220817.Models;

   public class LcicClient : AbstractClient{

       private const string endpoint = "lcic.tencentcloudapi.com";
       private const string version = "2022-08-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LcicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LcicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// This API is used to add users to a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="AddGroupMemberRequest"/></param>
        /// <returns><see cref="AddGroupMemberResponse"/></returns>
        public async Task<AddGroupMemberResponse> AddGroupMember(AddGroupMemberRequest req)
        {
             JsonResponseModel<AddGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add users to a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="AddGroupMemberRequest"/></param>
        /// <returns><see cref="AddGroupMemberResponse"/></returns>
        public AddGroupMemberResponse AddGroupMemberSync(AddGroupMemberRequest req)
        {
             JsonResponseModel<AddGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add users to multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchAddGroupMemberRequest"/></param>
        /// <returns><see cref="BatchAddGroupMemberResponse"/></returns>
        public async Task<BatchAddGroupMemberResponse> BatchAddGroupMember(BatchAddGroupMemberRequest req)
        {
             JsonResponseModel<BatchAddGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchAddGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchAddGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to add users to multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchAddGroupMemberRequest"/></param>
        /// <returns><see cref="BatchAddGroupMemberResponse"/></returns>
        public BatchAddGroupMemberResponse BatchAddGroupMemberSync(BatchAddGroupMemberRequest req)
        {
             JsonResponseModel<BatchAddGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchAddGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchAddGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="BatchCreateGroupWithMembersResponse"/></returns>
        public async Task<BatchCreateGroupWithMembersResponse> BatchCreateGroupWithMembers(BatchCreateGroupWithMembersRequest req)
        {
             JsonResponseModel<BatchCreateGroupWithMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchCreateGroupWithMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateGroupWithMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="BatchCreateGroupWithMembersResponse"/></returns>
        public BatchCreateGroupWithMembersResponse BatchCreateGroupWithMembersSync(BatchCreateGroupWithMembersRequest req)
        {
             JsonResponseModel<BatchCreateGroupWithMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchCreateGroupWithMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateGroupWithMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple rooms at a time.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateRoomRequest"/></param>
        /// <returns><see cref="BatchCreateRoomResponse"/></returns>
        public async Task<BatchCreateRoomResponse> BatchCreateRoom(BatchCreateRoomRequest req)
        {
             JsonResponseModel<BatchCreateRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchCreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create multiple rooms at a time.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateRoomRequest"/></param>
        /// <returns><see cref="BatchCreateRoomResponse"/></returns>
        public BatchCreateRoomResponse BatchCreateRoomSync(BatchCreateRoomRequest req)
        {
             JsonResponseModel<BatchCreateRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchCreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchCreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove users from multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteGroupMemberRequest"/></param>
        /// <returns><see cref="BatchDeleteGroupMemberResponse"/></returns>
        public async Task<BatchDeleteGroupMemberResponse> BatchDeleteGroupMember(BatchDeleteGroupMemberRequest req)
        {
             JsonResponseModel<BatchDeleteGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove users from multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteGroupMemberRequest"/></param>
        /// <returns><see cref="BatchDeleteGroupMemberResponse"/></returns>
        public BatchDeleteGroupMemberResponse BatchDeleteGroupMemberSync(BatchDeleteGroupMemberRequest req)
        {
             JsonResponseModel<BatchDeleteGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the recordings of multiple rooms.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRecordRequest"/></param>
        /// <returns><see cref="BatchDeleteRecordResponse"/></returns>
        public async Task<BatchDeleteRecordResponse> BatchDeleteRecord(BatchDeleteRecordRequest req)
        {
             JsonResponseModel<BatchDeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchDeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the recordings of multiple rooms.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRecordRequest"/></param>
        /// <returns><see cref="BatchDeleteRecordResponse"/></returns>
        public BatchDeleteRecordResponse BatchDeleteRecordSync(BatchDeleteRecordRequest req)
        {
             JsonResponseModel<BatchDeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchDeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchDeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to register multiple users (up to 1,000) at a time. If a user ID already exists, the existing one will be overwritten.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public async Task<BatchRegisterResponse> BatchRegister(BatchRegisterRequest req)
        {
             JsonResponseModel<BatchRegisterResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchRegister");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to register multiple users (up to 1,000) at a time. If a user ID already exists, the existing one will be overwritten.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public BatchRegisterResponse BatchRegisterSync(BatchRegisterRequest req)
        {
             JsonResponseModel<BatchRegisterResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchRegister");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchRegisterResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a document to a room.
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public async Task<BindDocumentToRoomResponse> BindDocumentToRoom(BindDocumentToRoomRequest req)
        {
             JsonResponseModel<BindDocumentToRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDocumentToRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDocumentToRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to bind a document to a room.
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public BindDocumentToRoomResponse BindDocumentToRoomSync(BindDocumentToRoomRequest req)
        {
             JsonResponseModel<BindDocumentToRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDocumentToRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDocumentToRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a document to be used in a room.
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public async Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a document to be used in a room.
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public CreateDocumentResponse CreateDocumentSync(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// his API is used to create a group and specify its members.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="CreateGroupWithMembersResponse"/></returns>
        public async Task<CreateGroupWithMembersResponse> CreateGroupWithMembers(CreateGroupWithMembersRequest req)
        {
             JsonResponseModel<CreateGroupWithMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroupWithMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupWithMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// his API is used to create a group and specify its members.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="CreateGroupWithMembersResponse"/></returns>
        public CreateGroupWithMembersResponse CreateGroupWithMembersSync(CreateGroupWithMembersRequest req)
        {
             JsonResponseModel<CreateGroupWithMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGroupWithMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupWithMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to merge groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithSubGroupRequest"/></param>
        /// <returns><see cref="CreateGroupWithSubGroupResponse"/></returns>
        public async Task<CreateGroupWithSubGroupResponse> CreateGroupWithSubGroup(CreateGroupWithSubGroupRequest req)
        {
             JsonResponseModel<CreateGroupWithSubGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroupWithSubGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupWithSubGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to merge groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithSubGroupRequest"/></param>
        /// <returns><see cref="CreateGroupWithSubGroupResponse"/></returns>
        public CreateGroupWithSubGroupResponse CreateGroupWithSubGroupSync(CreateGroupWithSubGroupRequest req)
        {
             JsonResponseModel<CreateGroupWithSubGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGroupWithSubGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupWithSubGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public async Task<CreateRoomResponse> CreateRoom(CreateRoomRequest req)
        {
             JsonResponseModel<CreateRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public CreateRoomResponse CreateRoomSync(CreateRoomRequest req)
        {
             JsonResponseModel<CreateRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a spectator.
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public async Task<CreateSupervisorResponse> CreateSupervisor(CreateSupervisorRequest req)
        {
             JsonResponseModel<CreateSupervisorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSupervisor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSupervisorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a spectator.
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public CreateSupervisorResponse CreateSupervisorSync(CreateSupervisorRequest req)
        {
             JsonResponseModel<CreateSupervisorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSupervisor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSupervisorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the custom elements. The `Scenes` parameter specifies the custom elements to delete. If `Scenes` is empty, all custom elements will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppCustomContentRequest"/></param>
        /// <returns><see cref="DeleteAppCustomContentResponse"/></returns>
        public async Task<DeleteAppCustomContentResponse> DeleteAppCustomContent(DeleteAppCustomContentRequest req)
        {
             JsonResponseModel<DeleteAppCustomContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAppCustomContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppCustomContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete the custom elements. The `Scenes` parameter specifies the custom elements to delete. If `Scenes` is empty, all custom elements will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppCustomContentRequest"/></param>
        /// <returns><see cref="DeleteAppCustomContentResponse"/></returns>
        public DeleteAppCustomContentResponse DeleteAppCustomContentSync(DeleteAppCustomContentRequest req)
        {
             JsonResponseModel<DeleteAppCustomContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAppCustomContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAppCustomContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocumentRequest"/></param>
        /// <returns><see cref="DeleteDocumentResponse"/></returns>
        public async Task<DeleteDocumentResponse> DeleteDocument(DeleteDocumentRequest req)
        {
             JsonResponseModel<DeleteDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocumentRequest"/></param>
        /// <returns><see cref="DeleteDocumentResponse"/></returns>
        public DeleteDocumentResponse DeleteDocumentSync(DeleteDocumentRequest req)
        {
             JsonResponseModel<DeleteDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete one or multiple groups.
        /// A maximum of 20 requests can be initiated per second for this API.
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
        /// This API is used to delete one or multiple groups.
        /// A maximum of 20 requests can be initiated per second for this API.
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
        /// This API is used to remove users from a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupMemberRequest"/></param>
        /// <returns><see cref="DeleteGroupMemberResponse"/></returns>
        public async Task<DeleteGroupMemberResponse> DeleteGroupMember(DeleteGroupMemberRequest req)
        {
             JsonResponseModel<DeleteGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to remove users from a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupMemberRequest"/></param>
        /// <returns><see cref="DeleteGroupMemberResponse"/></returns>
        public DeleteGroupMemberResponse DeleteGroupMemberSync(DeleteGroupMemberRequest req)
        {
             JsonResponseModel<DeleteGroupMemberResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGroupMember");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupMemberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This example shows you how to delete the recording files of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public async Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest req)
        {
             JsonResponseModel<DeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This example shows you how to delete the recording files of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public DeleteRecordResponse DeleteRecordSync(DeleteRecordRequest req)
        {
             JsonResponseModel<DeleteRecordResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRecord");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRecordResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public async Task<DeleteRoomResponse> DeleteRoom(DeleteRoomRequest req)
        {
             JsonResponseModel<DeleteRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public DeleteRoomResponse DeleteRoomSync(DeleteRoomRequest req)
        {
             JsonResponseModel<DeleteRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the user list of a room. This API will not work if a room has ended or expired.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentMemberListRequest"/></param>
        /// <returns><see cref="DescribeCurrentMemberListResponse"/></returns>
        public async Task<DescribeCurrentMemberListResponse> DescribeCurrentMemberList(DescribeCurrentMemberListRequest req)
        {
             JsonResponseModel<DescribeCurrentMemberListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCurrentMemberList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCurrentMemberListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the user list of a room. This API will not work if a room has ended or expired.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentMemberListRequest"/></param>
        /// <returns><see cref="DescribeCurrentMemberListResponse"/></returns>
        public DescribeCurrentMemberListResponse DescribeCurrentMemberListSync(DescribeCurrentMemberListRequest req)
        {
             JsonResponseModel<DescribeCurrentMemberListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCurrentMemberList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCurrentMemberListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the developer information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeveloperRequest"/></param>
        /// <returns><see cref="DescribeDeveloperResponse"/></returns>
        public async Task<DescribeDeveloperResponse> DescribeDeveloper(DescribeDeveloperRequest req)
        {
             JsonResponseModel<DescribeDeveloperResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeveloper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeveloperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the developer information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeveloperRequest"/></param>
        /// <returns><see cref="DescribeDeveloperResponse"/></returns>
        public DescribeDeveloperResponse DescribeDeveloperSync(DescribeDeveloperRequest req)
        {
             JsonResponseModel<DescribeDeveloperResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeveloper");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeveloperResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specific document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentRequest"/></param>
        /// <returns><see cref="DescribeDocumentResponse"/></returns>
        public async Task<DescribeDocumentResponse> DescribeDocument(DescribeDocumentRequest req)
        {
             JsonResponseModel<DescribeDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the information of a specific document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentRequest"/></param>
        /// <returns><see cref="DescribeDocumentResponse"/></returns>
        public DescribeDocumentResponse DescribeDocumentSync(DescribeDocumentRequest req)
        {
             JsonResponseModel<DescribeDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the document list of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsByRoomRequest"/></param>
        /// <returns><see cref="DescribeDocumentsByRoomResponse"/></returns>
        public async Task<DescribeDocumentsByRoomResponse> DescribeDocumentsByRoom(DescribeDocumentsByRoomRequest req)
        {
             JsonResponseModel<DescribeDocumentsByRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDocumentsByRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDocumentsByRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the document list of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsByRoomRequest"/></param>
        /// <returns><see cref="DescribeDocumentsByRoomResponse"/></returns>
        public DescribeDocumentsByRoomResponse DescribeDocumentsByRoomSync(DescribeDocumentsByRoomRequest req)
        {
             JsonResponseModel<DescribeDocumentsByRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDocumentsByRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDocumentsByRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public async Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the details of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
             JsonResponseModel<DescribeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupListRequest"/></param>
        /// <returns><see cref="DescribeGroupListResponse"/></returns>
        public async Task<DescribeGroupListResponse> DescribeGroupList(DescribeGroupListRequest req)
        {
             JsonResponseModel<DescribeGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupListRequest"/></param>
        /// <returns><see cref="DescribeGroupListResponse"/></returns>
        public DescribeGroupListResponse DescribeGroupListSync(DescribeGroupListRequest req)
        {
             JsonResponseModel<DescribeGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the members of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupMemberListRequest"/></param>
        /// <returns><see cref="DescribeGroupMemberListResponse"/></returns>
        public async Task<DescribeGroupMemberListResponse> DescribeGroupMemberList(DescribeGroupMemberListRequest req)
        {
             JsonResponseModel<DescribeGroupMemberListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeGroupMemberList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupMemberListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the members of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupMemberListRequest"/></param>
        /// <returns><see cref="DescribeGroupMemberListResponse"/></returns>
        public DescribeGroupMemberListResponse DescribeGroupMemberListSync(DescribeGroupMemberListRequest req)
        {
             JsonResponseModel<DescribeGroupMemberListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeGroupMemberList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeGroupMemberListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get room information.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public async Task<DescribeRoomResponse> DescribeRoom(DescribeRoomRequest req)
        {
             JsonResponseModel<DescribeRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get room information.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public DescribeRoomResponse DescribeRoomSync(DescribeRoomRequest req)
        {
             JsonResponseModel<DescribeRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the statistics of a room. It can be called only after the room is ended.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public async Task<DescribeRoomStatisticsResponse> DescribeRoomStatistics(DescribeRoomStatisticsRequest req)
        {
             JsonResponseModel<DescribeRoomStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoomStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain the statistics of a room. It can be called only after the room is ended.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public DescribeRoomStatisticsResponse DescribeRoomStatisticsSync(DescribeRoomStatisticsRequest req)
        {
             JsonResponseModel<DescribeRoomStatisticsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoomStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the user list of a specific application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppIdUsersRequest"/></param>
        /// <returns><see cref="DescribeSdkAppIdUsersResponse"/></returns>
        public async Task<DescribeSdkAppIdUsersResponse> DescribeSdkAppIdUsers(DescribeSdkAppIdUsersRequest req)
        {
             JsonResponseModel<DescribeSdkAppIdUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSdkAppIdUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSdkAppIdUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the user list of a specific application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppIdUsersRequest"/></param>
        /// <returns><see cref="DescribeSdkAppIdUsersResponse"/></returns>
        public DescribeSdkAppIdUsersResponse DescribeSdkAppIdUsersSync(DescribeSdkAppIdUsersRequest req)
        {
             JsonResponseModel<DescribeSdkAppIdUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSdkAppIdUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSdkAppIdUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain user profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public async Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to obtain user profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the events of a room. It only works within one hour after a class ends.
        /// </summary>
        /// <param name="req"><see cref="GetRoomEventRequest"/></param>
        /// <returns><see cref="GetRoomEventResponse"/></returns>
        public async Task<GetRoomEventResponse> GetRoomEvent(GetRoomEventRequest req)
        {
             JsonResponseModel<GetRoomEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRoomEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRoomEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the events of a room. It only works within one hour after a class ends.
        /// </summary>
        /// <param name="req"><see cref="GetRoomEventRequest"/></param>
        /// <returns><see cref="GetRoomEventResponse"/></returns>
        public GetRoomEventResponse GetRoomEventSync(GetRoomEventRequest req)
        {
             JsonResponseModel<GetRoomEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRoomEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRoomEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the message history of a room (room messages are retained for seven days).
        /// </summary>
        /// <param name="req"><see cref="GetRoomMessageRequest"/></param>
        /// <returns><see cref="GetRoomMessageResponse"/></returns>
        public async Task<GetRoomMessageResponse> GetRoomMessage(GetRoomMessageRequest req)
        {
             JsonResponseModel<GetRoomMessageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetRoomMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRoomMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get the message history of a room (room messages are retained for seven days).
        /// </summary>
        /// <param name="req"><see cref="GetRoomMessageRequest"/></param>
        /// <returns><see cref="GetRoomMessageResponse"/></returns>
        public GetRoomMessageResponse GetRoomMessageSync(GetRoomMessageRequest req)
        {
             JsonResponseModel<GetRoomMessageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetRoomMessage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetRoomMessageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get watermark settings.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="GetWatermarkRequest"/></param>
        /// <returns><see cref="GetWatermarkResponse"/></returns>
        public async Task<GetWatermarkResponse> GetWatermark(GetWatermarkRequest req)
        {
             JsonResponseModel<GetWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to get watermark settings.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="GetWatermarkRequest"/></param>
        /// <returns><see cref="GetWatermarkResponse"/></returns>
        public GetWatermarkResponse GetWatermarkSync(GetWatermarkRequest req)
        {
             JsonResponseModel<GetWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to log in with an origin account, which is the `originId` entered during registration.
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public async Task<LoginOriginIdResponse> LoginOriginId(LoginOriginIdRequest req)
        {
             JsonResponseModel<LoginOriginIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LoginOriginId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginOriginIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to log in with an origin account, which is the `originId` entered during registration.
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public LoginOriginIdResponse LoginOriginIdSync(LoginOriginIdRequest req)
        {
             JsonResponseModel<LoginOriginIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LoginOriginId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginOriginIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to log in.
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public async Task<LoginUserResponse> LoginUser(LoginUserRequest req)
        {
             JsonResponseModel<LoginUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LoginUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to log in.
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public LoginUserResponse LoginUserSync(LoginUserRequest req)
        {
             JsonResponseModel<LoginUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LoginUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public async Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
             JsonResponseModel<ModifyAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify an application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
             JsonResponseModel<ModifyAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a group.
        /// A maximum of 20 requests can be initiated per second for this API.
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
        /// This API is used to modify a group.
        /// A maximum of 20 requests can be initiated per second for this API.
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
        /// This API is used to modify a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public async Task<ModifyRoomResponse> ModifyRoom(ModifyRoomRequest req)
        {
             JsonResponseModel<ModifyRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public ModifyRoomResponse ModifyRoomSync(ModifyRoomRequest req)
        {
             JsonResponseModel<ModifyRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a user profile such as the nickname and profile photo.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserProfileRequest"/></param>
        /// <returns><see cref="ModifyUserProfileResponse"/></returns>
        public async Task<ModifyUserProfileResponse> ModifyUserProfile(ModifyUserProfileRequest req)
        {
             JsonResponseModel<ModifyUserProfileResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify a user profile such as the nickname and profile photo.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserProfileRequest"/></param>
        /// <returns><see cref="ModifyUserProfileResponse"/></returns>
        public ModifyUserProfileResponse ModifyUserProfileSync(ModifyUserProfileRequest req)
        {
             JsonResponseModel<ModifyUserProfileResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserProfile");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserProfileResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to register a user.
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest req)
        {
             JsonResponseModel<RegisterUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to register a user.
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public RegisterUserResponse RegisterUserSync(RegisterUserRequest req)
        {
             JsonResponseModel<RegisterUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set or update the custom content of an application, including the application icon and custom code. After you update JS and CSS content, you also need to call this API for the updates to take effect.
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public async Task<SetAppCustomContentResponse> SetAppCustomContent(SetAppCustomContentRequest req)
        {
             JsonResponseModel<SetAppCustomContentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetAppCustomContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAppCustomContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to set or update the custom content of an application, including the application icon and custom code. After you update JS and CSS content, you also need to call this API for the updates to take effect.
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public SetAppCustomContentResponse SetAppCustomContentSync(SetAppCustomContentRequest req)
        {
             JsonResponseModel<SetAppCustomContentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetAppCustomContent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetAppCustomContentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure watermarks.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SetWatermarkRequest"/></param>
        /// <returns><see cref="SetWatermarkResponse"/></returns>
        public async Task<SetWatermarkResponse> SetWatermark(SetWatermarkRequest req)
        {
             JsonResponseModel<SetWatermarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to configure watermarks.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SetWatermarkRequest"/></param>
        /// <returns><see cref="SetWatermarkResponse"/></returns>
        public SetWatermarkResponse SetWatermarkSync(SetWatermarkRequest req)
        {
             JsonResponseModel<SetWatermarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetWatermark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetWatermarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a document from a room.
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public async Task<UnbindDocumentFromRoomResponse> UnbindDocumentFromRoom(UnbindDocumentFromRoomRequest req)
        {
             JsonResponseModel<UnbindDocumentFromRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnbindDocumentFromRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDocumentFromRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unbind a document from a room.
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public UnbindDocumentFromRoomResponse UnbindDocumentFromRoomSync(UnbindDocumentFromRoomRequest req)
        {
             JsonResponseModel<UnbindDocumentFromRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnbindDocumentFromRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnbindDocumentFromRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
