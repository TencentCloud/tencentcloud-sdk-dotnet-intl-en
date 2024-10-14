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
       private const string sdkVersion = "SDK_NET_3.0.997";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LcicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
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
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to add users to a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="AddGroupMemberRequest"/></param>
        /// <returns><see cref="AddGroupMemberResponse"/></returns>
        public Task<AddGroupMemberResponse> AddGroupMember(AddGroupMemberRequest req)
        {
            return InternalRequestAsync<AddGroupMemberResponse>(req, "AddGroupMember");
        }

        /// <summary>
        /// This API is used to add users to a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="AddGroupMemberRequest"/></param>
        /// <returns><see cref="AddGroupMemberResponse"/></returns>
        public AddGroupMemberResponse AddGroupMemberSync(AddGroupMemberRequest req)
        {
            return InternalRequestAsync<AddGroupMemberResponse>(req, "AddGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to add users to multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchAddGroupMemberRequest"/></param>
        /// <returns><see cref="BatchAddGroupMemberResponse"/></returns>
        public Task<BatchAddGroupMemberResponse> BatchAddGroupMember(BatchAddGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchAddGroupMemberResponse>(req, "BatchAddGroupMember");
        }

        /// <summary>
        /// This API is used to add users to multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchAddGroupMemberRequest"/></param>
        /// <returns><see cref="BatchAddGroupMemberResponse"/></returns>
        public BatchAddGroupMemberResponse BatchAddGroupMemberSync(BatchAddGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchAddGroupMemberResponse>(req, "BatchAddGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="BatchCreateGroupWithMembersResponse"/></returns>
        public Task<BatchCreateGroupWithMembersResponse> BatchCreateGroupWithMembers(BatchCreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<BatchCreateGroupWithMembersResponse>(req, "BatchCreateGroupWithMembers");
        }

        /// <summary>
        /// This API is used to create multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="BatchCreateGroupWithMembersResponse"/></returns>
        public BatchCreateGroupWithMembersResponse BatchCreateGroupWithMembersSync(BatchCreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<BatchCreateGroupWithMembersResponse>(req, "BatchCreateGroupWithMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create multiple rooms at a time.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateRoomRequest"/></param>
        /// <returns><see cref="BatchCreateRoomResponse"/></returns>
        public Task<BatchCreateRoomResponse> BatchCreateRoom(BatchCreateRoomRequest req)
        {
            return InternalRequestAsync<BatchCreateRoomResponse>(req, "BatchCreateRoom");
        }

        /// <summary>
        /// This API is used to create multiple rooms at a time.
        /// </summary>
        /// <param name="req"><see cref="BatchCreateRoomRequest"/></param>
        /// <returns><see cref="BatchCreateRoomResponse"/></returns>
        public BatchCreateRoomResponse BatchCreateRoomSync(BatchCreateRoomRequest req)
        {
            return InternalRequestAsync<BatchCreateRoomResponse>(req, "BatchCreateRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove users from multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteGroupMemberRequest"/></param>
        /// <returns><see cref="BatchDeleteGroupMemberResponse"/></returns>
        public Task<BatchDeleteGroupMemberResponse> BatchDeleteGroupMember(BatchDeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchDeleteGroupMemberResponse>(req, "BatchDeleteGroupMember");
        }

        /// <summary>
        /// This API is used to remove users from multiple groups at a time.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteGroupMemberRequest"/></param>
        /// <returns><see cref="BatchDeleteGroupMemberResponse"/></returns>
        public BatchDeleteGroupMemberResponse BatchDeleteGroupMemberSync(BatchDeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<BatchDeleteGroupMemberResponse>(req, "BatchDeleteGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the recordings of multiple rooms.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRecordRequest"/></param>
        /// <returns><see cref="BatchDeleteRecordResponse"/></returns>
        public Task<BatchDeleteRecordResponse> BatchDeleteRecord(BatchDeleteRecordRequest req)
        {
            return InternalRequestAsync<BatchDeleteRecordResponse>(req, "BatchDeleteRecord");
        }

        /// <summary>
        /// This API is used to delete the recordings of multiple rooms.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchDeleteRecordRequest"/></param>
        /// <returns><see cref="BatchDeleteRecordResponse"/></returns>
        public BatchDeleteRecordResponse BatchDeleteRecordSync(BatchDeleteRecordRequest req)
        {
            return InternalRequestAsync<BatchDeleteRecordResponse>(req, "BatchDeleteRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get courseware information.
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeDocumentRequest"/></param>
        /// <returns><see cref="BatchDescribeDocumentResponse"/></returns>
        public Task<BatchDescribeDocumentResponse> BatchDescribeDocument(BatchDescribeDocumentRequest req)
        {
            return InternalRequestAsync<BatchDescribeDocumentResponse>(req, "BatchDescribeDocument");
        }

        /// <summary>
        /// This API is used to get courseware information.
        /// </summary>
        /// <param name="req"><see cref="BatchDescribeDocumentRequest"/></param>
        /// <returns><see cref="BatchDescribeDocumentResponse"/></returns>
        public BatchDescribeDocumentResponse BatchDescribeDocumentSync(BatchDescribeDocumentRequest req)
        {
            return InternalRequestAsync<BatchDescribeDocumentResponse>(req, "BatchDescribeDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to register multiple users (up to 1,000) at a time. If a user ID already exists, the existing one will be overwritten.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public Task<BatchRegisterResponse> BatchRegister(BatchRegisterRequest req)
        {
            return InternalRequestAsync<BatchRegisterResponse>(req, "BatchRegister");
        }

        /// <summary>
        /// This API is used to register multiple users (up to 1,000) at a time. If a user ID already exists, the existing one will be overwritten.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="BatchRegisterRequest"/></param>
        /// <returns><see cref="BatchRegisterResponse"/></returns>
        public BatchRegisterResponse BatchRegisterSync(BatchRegisterRequest req)
        {
            return InternalRequestAsync<BatchRegisterResponse>(req, "BatchRegister")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to bind a document to a room.
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public Task<BindDocumentToRoomResponse> BindDocumentToRoom(BindDocumentToRoomRequest req)
        {
            return InternalRequestAsync<BindDocumentToRoomResponse>(req, "BindDocumentToRoom");
        }

        /// <summary>
        /// This API is used to bind a document to a room.
        /// </summary>
        /// <param name="req"><see cref="BindDocumentToRoomRequest"/></param>
        /// <returns><see cref="BindDocumentToRoomResponse"/></returns>
        public BindDocumentToRoomResponse BindDocumentToRoomSync(BindDocumentToRoomRequest req)
        {
            return InternalRequestAsync<BindDocumentToRoomResponse>(req, "BindDocumentToRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a document to be used in a room.
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest req)
        {
            return InternalRequestAsync<CreateDocumentResponse>(req, "CreateDocument");
        }

        /// <summary>
        /// This API is used to create a document to be used in a room.
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public CreateDocumentResponse CreateDocumentSync(CreateDocumentRequest req)
        {
            return InternalRequestAsync<CreateDocumentResponse>(req, "CreateDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// his API is used to create a group and specify its members.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="CreateGroupWithMembersResponse"/></returns>
        public Task<CreateGroupWithMembersResponse> CreateGroupWithMembers(CreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<CreateGroupWithMembersResponse>(req, "CreateGroupWithMembers");
        }

        /// <summary>
        /// his API is used to create a group and specify its members.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithMembersRequest"/></param>
        /// <returns><see cref="CreateGroupWithMembersResponse"/></returns>
        public CreateGroupWithMembersResponse CreateGroupWithMembersSync(CreateGroupWithMembersRequest req)
        {
            return InternalRequestAsync<CreateGroupWithMembersResponse>(req, "CreateGroupWithMembers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to merge groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithSubGroupRequest"/></param>
        /// <returns><see cref="CreateGroupWithSubGroupResponse"/></returns>
        public Task<CreateGroupWithSubGroupResponse> CreateGroupWithSubGroup(CreateGroupWithSubGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupWithSubGroupResponse>(req, "CreateGroupWithSubGroup");
        }

        /// <summary>
        /// This API is used to merge groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateGroupWithSubGroupRequest"/></param>
        /// <returns><see cref="CreateGroupWithSubGroupResponse"/></returns>
        public CreateGroupWithSubGroupResponse CreateGroupWithSubGroupSync(CreateGroupWithSubGroupRequest req)
        {
            return InternalRequestAsync<CreateGroupWithSubGroupResponse>(req, "CreateGroupWithSubGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public Task<CreateRoomResponse> CreateRoom(CreateRoomRequest req)
        {
            return InternalRequestAsync<CreateRoomResponse>(req, "CreateRoom");
        }

        /// <summary>
        /// This API is used to create a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public CreateRoomResponse CreateRoomSync(CreateRoomRequest req)
        {
            return InternalRequestAsync<CreateRoomResponse>(req, "CreateRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a spectator.
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public Task<CreateSupervisorResponse> CreateSupervisor(CreateSupervisorRequest req)
        {
            return InternalRequestAsync<CreateSupervisorResponse>(req, "CreateSupervisor");
        }

        /// <summary>
        /// This API is used to create a spectator.
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public CreateSupervisorResponse CreateSupervisorSync(CreateSupervisorRequest req)
        {
            return InternalRequestAsync<CreateSupervisorResponse>(req, "CreateSupervisor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete the custom elements. The `Scenes` parameter specifies the custom elements to delete. If `Scenes` is empty, all custom elements will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppCustomContentRequest"/></param>
        /// <returns><see cref="DeleteAppCustomContentResponse"/></returns>
        public Task<DeleteAppCustomContentResponse> DeleteAppCustomContent(DeleteAppCustomContentRequest req)
        {
            return InternalRequestAsync<DeleteAppCustomContentResponse>(req, "DeleteAppCustomContent");
        }

        /// <summary>
        /// This API is used to delete the custom elements. The `Scenes` parameter specifies the custom elements to delete. If `Scenes` is empty, all custom elements will be deleted.
        /// </summary>
        /// <param name="req"><see cref="DeleteAppCustomContentRequest"/></param>
        /// <returns><see cref="DeleteAppCustomContentResponse"/></returns>
        public DeleteAppCustomContentResponse DeleteAppCustomContentSync(DeleteAppCustomContentRequest req)
        {
            return InternalRequestAsync<DeleteAppCustomContentResponse>(req, "DeleteAppCustomContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocumentRequest"/></param>
        /// <returns><see cref="DeleteDocumentResponse"/></returns>
        public Task<DeleteDocumentResponse> DeleteDocument(DeleteDocumentRequest req)
        {
            return InternalRequestAsync<DeleteDocumentResponse>(req, "DeleteDocument");
        }

        /// <summary>
        /// This API is used to delete a document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteDocumentRequest"/></param>
        /// <returns><see cref="DeleteDocumentResponse"/></returns>
        public DeleteDocumentResponse DeleteDocumentSync(DeleteDocumentRequest req)
        {
            return InternalRequestAsync<DeleteDocumentResponse>(req, "DeleteDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete one or multiple groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup");
        }

        /// <summary>
        /// This API is used to delete one or multiple groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
            return InternalRequestAsync<DeleteGroupResponse>(req, "DeleteGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove users from a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupMemberRequest"/></param>
        /// <returns><see cref="DeleteGroupMemberResponse"/></returns>
        public Task<DeleteGroupMemberResponse> DeleteGroupMember(DeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<DeleteGroupMemberResponse>(req, "DeleteGroupMember");
        }

        /// <summary>
        /// This API is used to remove users from a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupMemberRequest"/></param>
        /// <returns><see cref="DeleteGroupMemberResponse"/></returns>
        public DeleteGroupMemberResponse DeleteGroupMemberSync(DeleteGroupMemberRequest req)
        {
            return InternalRequestAsync<DeleteGroupMemberResponse>(req, "DeleteGroupMember")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This example shows you how to delete the recording files of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public Task<DeleteRecordResponse> DeleteRecord(DeleteRecordRequest req)
        {
            return InternalRequestAsync<DeleteRecordResponse>(req, "DeleteRecord");
        }

        /// <summary>
        /// This example shows you how to delete the recording files of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DeleteRecordRequest"/></param>
        /// <returns><see cref="DeleteRecordResponse"/></returns>
        public DeleteRecordResponse DeleteRecordSync(DeleteRecordRequest req)
        {
            return InternalRequestAsync<DeleteRecordResponse>(req, "DeleteRecord")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public Task<DeleteRoomResponse> DeleteRoom(DeleteRoomRequest req)
        {
            return InternalRequestAsync<DeleteRoomResponse>(req, "DeleteRoom");
        }

        /// <summary>
        /// This API is used to delete a room.
        /// </summary>
        /// <param name="req"><see cref="DeleteRoomRequest"/></param>
        /// <returns><see cref="DeleteRoomResponse"/></returns>
        public DeleteRoomResponse DeleteRoomSync(DeleteRoomRequest req)
        {
            return InternalRequestAsync<DeleteRoomResponse>(req, "DeleteRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete spectators.
        /// </summary>
        /// <param name="req"><see cref="DeleteSupervisorRequest"/></param>
        /// <returns><see cref="DeleteSupervisorResponse"/></returns>
        public Task<DeleteSupervisorResponse> DeleteSupervisor(DeleteSupervisorRequest req)
        {
            return InternalRequestAsync<DeleteSupervisorResponse>(req, "DeleteSupervisor");
        }

        /// <summary>
        /// This API is used to delete spectators.
        /// </summary>
        /// <param name="req"><see cref="DeleteSupervisorRequest"/></param>
        /// <returns><see cref="DeleteSupervisorResponse"/></returns>
        public DeleteSupervisorResponse DeleteSupervisorSync(DeleteSupervisorRequest req)
        {
            return InternalRequestAsync<DeleteSupervisorResponse>(req, "DeleteSupervisor")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the answers to a quiz question in a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnswerListRequest"/></param>
        /// <returns><see cref="DescribeAnswerListResponse"/></returns>
        public Task<DescribeAnswerListResponse> DescribeAnswerList(DescribeAnswerListRequest req)
        {
            return InternalRequestAsync<DescribeAnswerListResponse>(req, "DescribeAnswerList");
        }

        /// <summary>
        /// This API is used to get the answers to a quiz question in a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeAnswerListRequest"/></param>
        /// <returns><see cref="DescribeAnswerListResponse"/></returns>
        public DescribeAnswerListResponse DescribeAnswerListSync(DescribeAnswerListRequest req)
        {
            return InternalRequestAsync<DescribeAnswerListResponse>(req, "DescribeAnswerList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the user list of a room. This API will not work if a room has ended or expired.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentMemberListRequest"/></param>
        /// <returns><see cref="DescribeCurrentMemberListResponse"/></returns>
        public Task<DescribeCurrentMemberListResponse> DescribeCurrentMemberList(DescribeCurrentMemberListRequest req)
        {
            return InternalRequestAsync<DescribeCurrentMemberListResponse>(req, "DescribeCurrentMemberList");
        }

        /// <summary>
        /// This API is used to get the user list of a room. This API will not work if a room has ended or expired.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeCurrentMemberListRequest"/></param>
        /// <returns><see cref="DescribeCurrentMemberListResponse"/></returns>
        public DescribeCurrentMemberListResponse DescribeCurrentMemberListSync(DescribeCurrentMemberListRequest req)
        {
            return InternalRequestAsync<DescribeCurrentMemberListResponse>(req, "DescribeCurrentMemberList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get developer information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeveloperRequest"/></param>
        /// <returns><see cref="DescribeDeveloperResponse"/></returns>
        public Task<DescribeDeveloperResponse> DescribeDeveloper(DescribeDeveloperRequest req)
        {
            return InternalRequestAsync<DescribeDeveloperResponse>(req, "DescribeDeveloper");
        }

        /// <summary>
        /// This API is used to get developer information.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeveloperRequest"/></param>
        /// <returns><see cref="DescribeDeveloperResponse"/></returns>
        public DescribeDeveloperResponse DescribeDeveloperSync(DescribeDeveloperRequest req)
        {
            return InternalRequestAsync<DescribeDeveloperResponse>(req, "DescribeDeveloper")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the information of a specific document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentRequest"/></param>
        /// <returns><see cref="DescribeDocumentResponse"/></returns>
        public Task<DescribeDocumentResponse> DescribeDocument(DescribeDocumentRequest req)
        {
            return InternalRequestAsync<DescribeDocumentResponse>(req, "DescribeDocument");
        }

        /// <summary>
        /// This API is used to get the information of a specific document.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentRequest"/></param>
        /// <returns><see cref="DescribeDocumentResponse"/></returns>
        public DescribeDocumentResponse DescribeDocumentSync(DescribeDocumentRequest req)
        {
            return InternalRequestAsync<DescribeDocumentResponse>(req, "DescribeDocument")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// 有新接口替换
        /// 
        /// A new API is offered for this action now.
        /// 
        /// This API is used to query courseware. It has been deprecated. Please use `BatchDescribeDocument` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsRequest"/></param>
        /// <returns><see cref="DescribeDocumentsResponse"/></returns>
        public Task<DescribeDocumentsResponse> DescribeDocuments(DescribeDocumentsRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsResponse>(req, "DescribeDocuments");
        }

        /// <summary>
        /// 有新接口替换
        /// 
        /// A new API is offered for this action now.
        /// 
        /// This API is used to query courseware. It has been deprecated. Please use `BatchDescribeDocument` instead.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsRequest"/></param>
        /// <returns><see cref="DescribeDocumentsResponse"/></returns>
        public DescribeDocumentsResponse DescribeDocumentsSync(DescribeDocumentsRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsResponse>(req, "DescribeDocuments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the document list of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsByRoomRequest"/></param>
        /// <returns><see cref="DescribeDocumentsByRoomResponse"/></returns>
        public Task<DescribeDocumentsByRoomResponse> DescribeDocumentsByRoom(DescribeDocumentsByRoomRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsByRoomResponse>(req, "DescribeDocumentsByRoom");
        }

        /// <summary>
        /// This API is used to get the document list of a specific room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeDocumentsByRoomRequest"/></param>
        /// <returns><see cref="DescribeDocumentsByRoomResponse"/></returns>
        public DescribeDocumentsByRoomResponse DescribeDocumentsByRoomSync(DescribeDocumentsByRoomRequest req)
        {
            return InternalRequestAsync<DescribeDocumentsByRoomResponse>(req, "DescribeDocumentsByRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the details of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public Task<DescribeGroupResponse> DescribeGroup(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup");
        }

        /// <summary>
        /// This API is used to get the details of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupRequest"/></param>
        /// <returns><see cref="DescribeGroupResponse"/></returns>
        public DescribeGroupResponse DescribeGroupSync(DescribeGroupRequest req)
        {
            return InternalRequestAsync<DescribeGroupResponse>(req, "DescribeGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupListRequest"/></param>
        /// <returns><see cref="DescribeGroupListResponse"/></returns>
        public Task<DescribeGroupListResponse> DescribeGroupList(DescribeGroupListRequest req)
        {
            return InternalRequestAsync<DescribeGroupListResponse>(req, "DescribeGroupList");
        }

        /// <summary>
        /// This API is used to query groups.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupListRequest"/></param>
        /// <returns><see cref="DescribeGroupListResponse"/></returns>
        public DescribeGroupListResponse DescribeGroupListSync(DescribeGroupListRequest req)
        {
            return InternalRequestAsync<DescribeGroupListResponse>(req, "DescribeGroupList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the members of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupMemberListRequest"/></param>
        /// <returns><see cref="DescribeGroupMemberListResponse"/></returns>
        public Task<DescribeGroupMemberListResponse> DescribeGroupMemberList(DescribeGroupMemberListRequest req)
        {
            return InternalRequestAsync<DescribeGroupMemberListResponse>(req, "DescribeGroupMemberList");
        }

        /// <summary>
        /// This API is used to get the members of a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeGroupMemberListRequest"/></param>
        /// <returns><see cref="DescribeGroupMemberListResponse"/></returns>
        public DescribeGroupMemberListResponse DescribeGroupMemberListSync(DescribeGroupMemberListRequest req)
        {
            return InternalRequestAsync<DescribeGroupMemberListResponse>(req, "DescribeGroupMemberList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the quiz details of a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuestionListRequest"/></param>
        /// <returns><see cref="DescribeQuestionListResponse"/></returns>
        public Task<DescribeQuestionListResponse> DescribeQuestionList(DescribeQuestionListRequest req)
        {
            return InternalRequestAsync<DescribeQuestionListResponse>(req, "DescribeQuestionList");
        }

        /// <summary>
        /// This API is used to get the quiz details of a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeQuestionListRequest"/></param>
        /// <returns><see cref="DescribeQuestionListResponse"/></returns>
        public DescribeQuestionListResponse DescribeQuestionListSync(DescribeQuestionListRequest req)
        {
            return InternalRequestAsync<DescribeQuestionListResponse>(req, "DescribeQuestionList")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get room information.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public Task<DescribeRoomResponse> DescribeRoom(DescribeRoomRequest req)
        {
            return InternalRequestAsync<DescribeRoomResponse>(req, "DescribeRoom");
        }

        /// <summary>
        /// This API is used to get room information.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public DescribeRoomResponse DescribeRoomSync(DescribeRoomRequest req)
        {
            return InternalRequestAsync<DescribeRoomResponse>(req, "DescribeRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain the statistics of a room. It can be called only after the room is ended.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public Task<DescribeRoomStatisticsResponse> DescribeRoomStatistics(DescribeRoomStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRoomStatisticsResponse>(req, "DescribeRoomStatistics");
        }

        /// <summary>
        /// This API is used to obtain the statistics of a room. It can be called only after the room is ended.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomStatisticsRequest"/></param>
        /// <returns><see cref="DescribeRoomStatisticsResponse"/></returns>
        public DescribeRoomStatisticsResponse DescribeRoomStatisticsSync(DescribeRoomStatisticsRequest req)
        {
            return InternalRequestAsync<DescribeRoomStatisticsResponse>(req, "DescribeRoomStatistics")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the user list of a specific application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppIdUsersRequest"/></param>
        /// <returns><see cref="DescribeSdkAppIdUsersResponse"/></returns>
        public Task<DescribeSdkAppIdUsersResponse> DescribeSdkAppIdUsers(DescribeSdkAppIdUsersRequest req)
        {
            return InternalRequestAsync<DescribeSdkAppIdUsersResponse>(req, "DescribeSdkAppIdUsers");
        }

        /// <summary>
        /// This API is used to get the user list of a specific application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="DescribeSdkAppIdUsersRequest"/></param>
        /// <returns><see cref="DescribeSdkAppIdUsersResponse"/></returns>
        public DescribeSdkAppIdUsersResponse DescribeSdkAppIdUsersSync(DescribeSdkAppIdUsersRequest req)
        {
            return InternalRequestAsync<DescribeSdkAppIdUsersResponse>(req, "DescribeSdkAppIdUsers")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the spectators of a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupervisorsRequest"/></param>
        /// <returns><see cref="DescribeSupervisorsResponse"/></returns>
        public Task<DescribeSupervisorsResponse> DescribeSupervisors(DescribeSupervisorsRequest req)
        {
            return InternalRequestAsync<DescribeSupervisorsResponse>(req, "DescribeSupervisors");
        }

        /// <summary>
        /// This API is used to get the spectators of a room.
        /// </summary>
        /// <param name="req"><see cref="DescribeSupervisorsRequest"/></param>
        /// <returns><see cref="DescribeSupervisorsResponse"/></returns>
        public DescribeSupervisorsResponse DescribeSupervisorsSync(DescribeSupervisorsRequest req)
        {
            return InternalRequestAsync<DescribeSupervisorsResponse>(req, "DescribeSupervisors")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to obtain user profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser");
        }

        /// <summary>
        /// This API is used to obtain user profile.
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
            return InternalRequestAsync<DescribeUserResponse>(req, "DescribeUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to end a room.
        /// </summary>
        /// <param name="req"><see cref="EndRoomRequest"/></param>
        /// <returns><see cref="EndRoomResponse"/></returns>
        public Task<EndRoomResponse> EndRoom(EndRoomRequest req)
        {
            return InternalRequestAsync<EndRoomResponse>(req, "EndRoom");
        }

        /// <summary>
        /// This API is used to end a room.
        /// </summary>
        /// <param name="req"><see cref="EndRoomRequest"/></param>
        /// <returns><see cref="EndRoomResponse"/></returns>
        public EndRoomResponse EndRoomSync(EndRoomRequest req)
        {
            return InternalRequestAsync<EndRoomResponse>(req, "EndRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the events of a room. It only works within one hour after a class ends.
        /// </summary>
        /// <param name="req"><see cref="GetRoomEventRequest"/></param>
        /// <returns><see cref="GetRoomEventResponse"/></returns>
        public Task<GetRoomEventResponse> GetRoomEvent(GetRoomEventRequest req)
        {
            return InternalRequestAsync<GetRoomEventResponse>(req, "GetRoomEvent");
        }

        /// <summary>
        /// This API is used to get the events of a room. It only works within one hour after a class ends.
        /// </summary>
        /// <param name="req"><see cref="GetRoomEventRequest"/></param>
        /// <returns><see cref="GetRoomEventResponse"/></returns>
        public GetRoomEventResponse GetRoomEventSync(GetRoomEventRequest req)
        {
            return InternalRequestAsync<GetRoomEventResponse>(req, "GetRoomEvent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the message history of a room (room messages are retained for seven days).
        /// </summary>
        /// <param name="req"><see cref="GetRoomMessageRequest"/></param>
        /// <returns><see cref="GetRoomMessageResponse"/></returns>
        public Task<GetRoomMessageResponse> GetRoomMessage(GetRoomMessageRequest req)
        {
            return InternalRequestAsync<GetRoomMessageResponse>(req, "GetRoomMessage");
        }

        /// <summary>
        /// This API is used to get the message history of a room (room messages are retained for seven days).
        /// </summary>
        /// <param name="req"><see cref="GetRoomMessageRequest"/></param>
        /// <returns><see cref="GetRoomMessageResponse"/></returns>
        public GetRoomMessageResponse GetRoomMessageSync(GetRoomMessageRequest req)
        {
            return InternalRequestAsync<GetRoomMessageResponse>(req, "GetRoomMessage")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the room list.
        /// </summary>
        /// <param name="req"><see cref="GetRoomsRequest"/></param>
        /// <returns><see cref="GetRoomsResponse"/></returns>
        public Task<GetRoomsResponse> GetRooms(GetRoomsRequest req)
        {
            return InternalRequestAsync<GetRoomsResponse>(req, "GetRooms");
        }

        /// <summary>
        /// This API is used to get the room list.
        /// </summary>
        /// <param name="req"><see cref="GetRoomsRequest"/></param>
        /// <returns><see cref="GetRoomsResponse"/></returns>
        public GetRoomsResponse GetRoomsSync(GetRoomsRequest req)
        {
            return InternalRequestAsync<GetRoomsResponse>(req, "GetRooms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get watermark settings.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="GetWatermarkRequest"/></param>
        /// <returns><see cref="GetWatermarkResponse"/></returns>
        public Task<GetWatermarkResponse> GetWatermark(GetWatermarkRequest req)
        {
            return InternalRequestAsync<GetWatermarkResponse>(req, "GetWatermark");
        }

        /// <summary>
        /// This API is used to get watermark settings.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="GetWatermarkRequest"/></param>
        /// <returns><see cref="GetWatermarkResponse"/></returns>
        public GetWatermarkResponse GetWatermarkSync(GetWatermarkRequest req)
        {
            return InternalRequestAsync<GetWatermarkResponse>(req, "GetWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to remove a user from the room.
        /// </summary>
        /// <param name="req"><see cref="KickUserFromRoomRequest"/></param>
        /// <returns><see cref="KickUserFromRoomResponse"/></returns>
        public Task<KickUserFromRoomResponse> KickUserFromRoom(KickUserFromRoomRequest req)
        {
            return InternalRequestAsync<KickUserFromRoomResponse>(req, "KickUserFromRoom");
        }

        /// <summary>
        /// This API is used to remove a user from the room.
        /// </summary>
        /// <param name="req"><see cref="KickUserFromRoomRequest"/></param>
        /// <returns><see cref="KickUserFromRoomResponse"/></returns>
        public KickUserFromRoomResponse KickUserFromRoomSync(KickUserFromRoomRequest req)
        {
            return InternalRequestAsync<KickUserFromRoomResponse>(req, "KickUserFromRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to log in with an origin account, which is the `originId` entered during registration.
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public Task<LoginOriginIdResponse> LoginOriginId(LoginOriginIdRequest req)
        {
            return InternalRequestAsync<LoginOriginIdResponse>(req, "LoginOriginId");
        }

        /// <summary>
        /// This API is used to log in with an origin account, which is the `originId` entered during registration.
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public LoginOriginIdResponse LoginOriginIdSync(LoginOriginIdRequest req)
        {
            return InternalRequestAsync<LoginOriginIdResponse>(req, "LoginOriginId")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to log in.
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public Task<LoginUserResponse> LoginUser(LoginUserRequest req)
        {
            return InternalRequestAsync<LoginUserResponse>(req, "LoginUser");
        }

        /// <summary>
        /// This API is used to log in.
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public LoginUserResponse LoginUserSync(LoginUserRequest req)
        {
            return InternalRequestAsync<LoginUserResponse>(req, "LoginUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public Task<ModifyAppResponse> ModifyApp(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp");
        }

        /// <summary>
        /// This API is used to modify an application.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyAppRequest"/></param>
        /// <returns><see cref="ModifyAppResponse"/></returns>
        public ModifyAppResponse ModifyAppSync(ModifyAppRequest req)
        {
            return InternalRequestAsync<ModifyAppResponse>(req, "ModifyApp")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup");
        }

        /// <summary>
        /// This API is used to modify a group.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
            return InternalRequestAsync<ModifyGroupResponse>(req, "ModifyGroup")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public Task<ModifyRoomResponse> ModifyRoom(ModifyRoomRequest req)
        {
            return InternalRequestAsync<ModifyRoomResponse>(req, "ModifyRoom");
        }

        /// <summary>
        /// This API is used to modify a room.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyRoomRequest"/></param>
        /// <returns><see cref="ModifyRoomResponse"/></returns>
        public ModifyRoomResponse ModifyRoomSync(ModifyRoomRequest req)
        {
            return InternalRequestAsync<ModifyRoomResponse>(req, "ModifyRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a user profile such as the nickname and profile photo.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserProfileRequest"/></param>
        /// <returns><see cref="ModifyUserProfileResponse"/></returns>
        public Task<ModifyUserProfileResponse> ModifyUserProfile(ModifyUserProfileRequest req)
        {
            return InternalRequestAsync<ModifyUserProfileResponse>(req, "ModifyUserProfile");
        }

        /// <summary>
        /// This API is used to modify a user profile such as the nickname and profile photo.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="ModifyUserProfileRequest"/></param>
        /// <returns><see cref="ModifyUserProfileResponse"/></returns>
        public ModifyUserProfileResponse ModifyUserProfileSync(ModifyUserProfileRequest req)
        {
            return InternalRequestAsync<ModifyUserProfileResponse>(req, "ModifyUserProfile")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to register a user.
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public Task<RegisterUserResponse> RegisterUser(RegisterUserRequest req)
        {
            return InternalRequestAsync<RegisterUserResponse>(req, "RegisterUser");
        }

        /// <summary>
        /// This API is used to register a user.
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public RegisterUserResponse RegisterUserSync(RegisterUserRequest req)
        {
            return InternalRequestAsync<RegisterUserResponse>(req, "RegisterUser")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to set or update the custom content of an application, including the application icon and custom code. After you update JS and CSS content, you also need to call this API for the updates to take effect.
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public Task<SetAppCustomContentResponse> SetAppCustomContent(SetAppCustomContentRequest req)
        {
            return InternalRequestAsync<SetAppCustomContentResponse>(req, "SetAppCustomContent");
        }

        /// <summary>
        /// This API is used to set or update the custom content of an application, including the application icon and custom code. After you update JS and CSS content, you also need to call this API for the updates to take effect.
        /// </summary>
        /// <param name="req"><see cref="SetAppCustomContentRequest"/></param>
        /// <returns><see cref="SetAppCustomContentResponse"/></returns>
        public SetAppCustomContentResponse SetAppCustomContentSync(SetAppCustomContentRequest req)
        {
            return InternalRequestAsync<SetAppCustomContentResponse>(req, "SetAppCustomContent")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to configure watermarks.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SetWatermarkRequest"/></param>
        /// <returns><see cref="SetWatermarkResponse"/></returns>
        public Task<SetWatermarkResponse> SetWatermark(SetWatermarkRequest req)
        {
            return InternalRequestAsync<SetWatermarkResponse>(req, "SetWatermark");
        }

        /// <summary>
        /// This API is used to configure watermarks.
        /// A maximum of 20 requests can be initiated per second for this API.
        /// </summary>
        /// <param name="req"><see cref="SetWatermarkRequest"/></param>
        /// <returns><see cref="SetWatermarkResponse"/></returns>
        public SetWatermarkResponse SetWatermarkSync(SetWatermarkRequest req)
        {
            return InternalRequestAsync<SetWatermarkResponse>(req, "SetWatermark")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to start a room. Before you call this API, make sure a user has entered the room so that the class is initialized.
        /// </summary>
        /// <param name="req"><see cref="StartRoomRequest"/></param>
        /// <returns><see cref="StartRoomResponse"/></returns>
        public Task<StartRoomResponse> StartRoom(StartRoomRequest req)
        {
            return InternalRequestAsync<StartRoomResponse>(req, "StartRoom");
        }

        /// <summary>
        /// This API is used to start a room. Before you call this API, make sure a user has entered the room so that the class is initialized.
        /// </summary>
        /// <param name="req"><see cref="StartRoomRequest"/></param>
        /// <returns><see cref="StartRoomResponse"/></returns>
        public StartRoomResponse StartRoomSync(StartRoomRequest req)
        {
            return InternalRequestAsync<StartRoomResponse>(req, "StartRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a document from a room.
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public Task<UnbindDocumentFromRoomResponse> UnbindDocumentFromRoom(UnbindDocumentFromRoomRequest req)
        {
            return InternalRequestAsync<UnbindDocumentFromRoomResponse>(req, "UnbindDocumentFromRoom");
        }

        /// <summary>
        /// This API is used to unbind a document from a room.
        /// </summary>
        /// <param name="req"><see cref="UnbindDocumentFromRoomRequest"/></param>
        /// <returns><see cref="UnbindDocumentFromRoomResponse"/></returns>
        public UnbindDocumentFromRoomResponse UnbindDocumentFromRoomSync(UnbindDocumentFromRoomRequest req)
        {
            return InternalRequestAsync<UnbindDocumentFromRoomResponse>(req, "UnbindDocumentFromRoom")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
