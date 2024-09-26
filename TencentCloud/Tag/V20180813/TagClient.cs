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

namespace TencentCloud.Tag.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tag.V20180813.Models;

   public class TagClient : AbstractClient{

       private const string endpoint = "tag.tencentcloudapi.com";
       private const string version = "2018-08-13";
       private const string sdkVersion = "SDK_NET_3.0.988";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TagClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TagClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to associate resources with tags.
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public Task<AddResourceTagResponse> AddResourceTag(AddResourceTagRequest req)
        {
            return InternalRequestAsync<AddResourceTagResponse>(req, "AddResourceTag");
        }

        /// <summary>
        /// This API is used to associate resources with tags.
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public AddResourceTagResponse AddResourceTagSync(AddResourceTagRequest req)
        {
            return InternalRequestAsync<AddResourceTagResponse>(req, "AddResourceTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to associate a tag with multiple resources.
        /// </summary>
        /// <param name="req"><see cref="AttachResourcesTagRequest"/></param>
        /// <returns><see cref="AttachResourcesTagResponse"/></returns>
        public Task<AttachResourcesTagResponse> AttachResourcesTag(AttachResourcesTagRequest req)
        {
            return InternalRequestAsync<AttachResourcesTagResponse>(req, "AttachResourcesTag");
        }

        /// <summary>
        /// This API is used to associate a tag with multiple resources.
        /// </summary>
        /// <param name="req"><see cref="AttachResourcesTagRequest"/></param>
        /// <returns><see cref="AttachResourcesTagResponse"/></returns>
        public AttachResourcesTagResponse AttachResourcesTagSync(AttachResourcesTagRequest req)
        {
            return InternalRequestAsync<AttachResourcesTagResponse>(req, "AttachResourcesTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public Task<CreateTagResponse> CreateTag(CreateTagRequest req)
        {
            return InternalRequestAsync<CreateTagResponse>(req, "CreateTag");
        }

        /// <summary>
        /// This API is used to create a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public CreateTagResponse CreateTagSync(CreateTagRequest req)
        {
            return InternalRequestAsync<CreateTagResponse>(req, "CreateTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create multiple tag key-value pairs.
        /// </summary>
        /// <param name="req"><see cref="CreateTagsRequest"/></param>
        /// <returns><see cref="CreateTagsResponse"/></returns>
        public Task<CreateTagsResponse> CreateTags(CreateTagsRequest req)
        {
            return InternalRequestAsync<CreateTagsResponse>(req, "CreateTags");
        }

        /// <summary>
        /// This API is used to create multiple tag key-value pairs.
        /// </summary>
        /// <param name="req"><see cref="CreateTagsRequest"/></param>
        /// <returns><see cref="CreateTagsResponse"/></returns>
        public CreateTagsResponse CreateTagsSync(CreateTagsRequest req)
        {
            return InternalRequestAsync<CreateTagsResponse>(req, "CreateTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unassociate tags and resources.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public Task<DeleteResourceTagResponse> DeleteResourceTag(DeleteResourceTagRequest req)
        {
            return InternalRequestAsync<DeleteResourceTagResponse>(req, "DeleteResourceTag");
        }

        /// <summary>
        /// This API is used to unassociate tags and resources.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public DeleteResourceTagResponse DeleteResourceTagSync(DeleteResourceTagRequest req)
        {
            return InternalRequestAsync<DeleteResourceTagResponse>(req, "DeleteResourceTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public Task<DeleteTagResponse> DeleteTag(DeleteTagRequest req)
        {
            return InternalRequestAsync<DeleteTagResponse>(req, "DeleteTag");
        }

        /// <summary>
        /// This API is used to delete a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public DeleteTagResponse DeleteTagSync(DeleteTagRequest req)
        {
            return InternalRequestAsync<DeleteTagResponse>(req, "DeleteTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete tag keys and tag values in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public Task<DeleteTagsResponse> DeleteTags(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags");
        }

        /// <summary>
        /// This API is used to delete tag keys and tag values in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagsRequest"/></param>
        /// <returns><see cref="DeleteTagsResponse"/></returns>
        public DeleteTagsResponse DeleteTagsSync(DeleteTagsRequest req)
        {
            return InternalRequestAsync<DeleteTagsResponse>(req, "DeleteTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get project lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// This API is used to get project lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the tags associated with a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public Task<DescribeResourceTagsResponse> DescribeResourceTags(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags");
        }

        /// <summary>
        /// This API is used to query the tags associated with a resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsResponse"/></returns>
        public DescribeResourceTagsResponse DescribeResourceTagsSync(DescribeResourceTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsResponse>(req, "DescribeResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the tag key-value pairs associated with an existing resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public Task<DescribeResourceTagsByResourceIdsResponse> DescribeResourceTagsByResourceIds(DescribeResourceTagsByResourceIdsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsResponse>(req, "DescribeResourceTagsByResourceIds");
        }

        /// <summary>
        /// This API is used to query the tag key-value pairs associated with an existing resource.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public DescribeResourceTagsByResourceIdsResponse DescribeResourceTagsByResourceIdsSync(DescribeResourceTagsByResourceIdsRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsResponse>(req, "DescribeResourceTagsByResourceIds")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to view the tags associated with a resource in sequence.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsSeqRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsSeqResponse"/></returns>
        public Task<DescribeResourceTagsByResourceIdsSeqResponse> DescribeResourceTagsByResourceIdsSeq(DescribeResourceTagsByResourceIdsSeqRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsSeqResponse>(req, "DescribeResourceTagsByResourceIdsSeq");
        }

        /// <summary>
        /// This API is used to view the tags associated with a resource in sequence.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsSeqRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsSeqResponse"/></returns>
        public DescribeResourceTagsByResourceIdsSeqResponse DescribeResourceTagsByResourceIdsSeqSync(DescribeResourceTagsByResourceIdsSeqRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByResourceIdsSeqResponse>(req, "DescribeResourceTagsByResourceIdsSeq")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get resource tags based on tag keys.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByTagKeysRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByTagKeysResponse"/></returns>
        public Task<DescribeResourceTagsByTagKeysResponse> DescribeResourceTagsByTagKeys(DescribeResourceTagsByTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByTagKeysResponse>(req, "DescribeResourceTagsByTagKeys");
        }

        /// <summary>
        /// This API is used to get resource tags based on tag keys.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByTagKeysRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByTagKeysResponse"/></returns>
        public DescribeResourceTagsByTagKeysResponse DescribeResourceTagsByTagKeysSync(DescribeResourceTagsByTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeResourceTagsByTagKeysResponse>(req, "DescribeResourceTagsByTagKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query resources by tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public Task<DescribeResourcesByTagsResponse> DescribeResourcesByTags(DescribeResourcesByTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsResponse>(req, "DescribeResourcesByTags");
        }

        /// <summary>
        /// This API is used to query resources by tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public DescribeResourcesByTagsResponse DescribeResourcesByTagsSync(DescribeResourcesByTagsRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsResponse>(req, "DescribeResourcesByTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query resource list by tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsUnionRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsUnionResponse"/></returns>
        public Task<DescribeResourcesByTagsUnionResponse> DescribeResourcesByTagsUnion(DescribeResourcesByTagsUnionRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsUnionResponse>(req, "DescribeResourcesByTagsUnion");
        }

        /// <summary>
        /// This API is used to query resource list by tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsUnionRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsUnionResponse"/></returns>
        public DescribeResourcesByTagsUnionResponse DescribeResourcesByTagsUnionSync(DescribeResourcesByTagsUnionRequest req)
        {
            return InternalRequestAsync<DescribeResourcesByTagsUnionResponse>(req, "DescribeResourcesByTagsUnion")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query tag keys in the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public Task<DescribeTagKeysResponse> DescribeTagKeys(DescribeTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeTagKeysResponse>(req, "DescribeTagKeys");
        }

        /// <summary>
        /// This API is used to query tag keys in the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public DescribeTagKeysResponse DescribeTagKeysSync(DescribeTagKeysRequest req)
        {
            return InternalRequestAsync<DescribeTagKeysResponse>(req, "DescribeTagKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query tag values in an existing tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues");
        }

        /// <summary>
        /// This API is used to query tag values in an existing tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public DescribeTagValuesResponse DescribeTagValuesSync(DescribeTagValuesRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesResponse>(req, "DescribeTagValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query tag values in a created tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesSeqRequest"/></param>
        /// <returns><see cref="DescribeTagValuesSeqResponse"/></returns>
        public Task<DescribeTagValuesSeqResponse> DescribeTagValuesSeq(DescribeTagValuesSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesSeqResponse>(req, "DescribeTagValuesSeq");
        }

        /// <summary>
        /// This API is used to query tag values in a created tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesSeqRequest"/></param>
        /// <returns><see cref="DescribeTagValuesSeqResponse"/></returns>
        public DescribeTagValuesSeqResponse DescribeTagValuesSeqSync(DescribeTagValuesSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagValuesSeqResponse>(req, "DescribeTagValuesSeq")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags");
        }

        /// <summary>
        /// This API is used to query the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
            return InternalRequestAsync<DescribeTagsResponse>(req, "DescribeTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the created tag lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsSeqRequest"/></param>
        /// <returns><see cref="DescribeTagsSeqResponse"/></returns>
        public Task<DescribeTagsSeqResponse> DescribeTagsSeq(DescribeTagsSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagsSeqResponse>(req, "DescribeTagsSeq");
        }

        /// <summary>
        /// This API is used to query the created tag lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsSeqRequest"/></param>
        /// <returns><see cref="DescribeTagsSeqResponse"/></returns>
        public DescribeTagsSeqResponse DescribeTagsSeqSync(DescribeTagsSeqRequest req)
        {
            return InternalRequestAsync<DescribeTagsSeqResponse>(req, "DescribeTagsSeq")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a tag from multiple resources.
        /// </summary>
        /// <param name="req"><see cref="DetachResourcesTagRequest"/></param>
        /// <returns><see cref="DetachResourcesTagResponse"/></returns>
        public Task<DetachResourcesTagResponse> DetachResourcesTag(DetachResourcesTagRequest req)
        {
            return InternalRequestAsync<DetachResourcesTagResponse>(req, "DetachResourcesTag");
        }

        /// <summary>
        /// This API is used to unbind a tag from multiple resources.
        /// </summary>
        /// <param name="req"><see cref="DetachResourcesTagRequest"/></param>
        /// <returns><see cref="DetachResourcesTagResponse"/></returns>
        public DetachResourcesTagResponse DetachResourcesTagSync(DetachResourcesTagRequest req)
        {
            return InternalRequestAsync<DetachResourcesTagResponse>(req, "DetachResourcesTag")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of resources associated with a tag.
        /// </summary>
        /// <param name="req"><see cref="GetResourcesRequest"/></param>
        /// <returns><see cref="GetResourcesResponse"/></returns>
        public Task<GetResourcesResponse> GetResources(GetResourcesRequest req)
        {
            return InternalRequestAsync<GetResourcesResponse>(req, "GetResources");
        }

        /// <summary>
        /// This API is used to query the list of resources associated with a tag.
        /// </summary>
        /// <param name="req"><see cref="GetResourcesRequest"/></param>
        /// <returns><see cref="GetResourcesResponse"/></returns>
        public GetResourcesResponse GetResourcesSync(GetResourcesRequest req)
        {
            return InternalRequestAsync<GetResourcesResponse>(req, "GetResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the list of tag keys.
        /// </summary>
        /// <param name="req"><see cref="GetTagKeysRequest"/></param>
        /// <returns><see cref="GetTagKeysResponse"/></returns>
        public Task<GetTagKeysResponse> GetTagKeys(GetTagKeysRequest req)
        {
            return InternalRequestAsync<GetTagKeysResponse>(req, "GetTagKeys");
        }

        /// <summary>
        /// This API is used to query the list of tag keys.
        /// </summary>
        /// <param name="req"><see cref="GetTagKeysRequest"/></param>
        /// <returns><see cref="GetTagKeysResponse"/></returns>
        public GetTagKeysResponse GetTagKeysSync(GetTagKeysRequest req)
        {
            return InternalRequestAsync<GetTagKeysResponse>(req, "GetTagKeys")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query tag values in the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="GetTagValuesRequest"/></param>
        /// <returns><see cref="GetTagValuesResponse"/></returns>
        public Task<GetTagValuesResponse> GetTagValues(GetTagValuesRequest req)
        {
            return InternalRequestAsync<GetTagValuesResponse>(req, "GetTagValues");
        }

        /// <summary>
        /// This API is used to query tag values in the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="GetTagValuesRequest"/></param>
        /// <returns><see cref="GetTagValuesResponse"/></returns>
        public GetTagValuesResponse GetTagValuesSync(GetTagValuesRequest req)
        {
            return InternalRequestAsync<GetTagValuesResponse>(req, "GetTagValues")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to get the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="GetTagsRequest"/></param>
        /// <returns><see cref="GetTagsResponse"/></returns>
        public Task<GetTagsResponse> GetTags(GetTagsRequest req)
        {
            return InternalRequestAsync<GetTagsResponse>(req, "GetTags");
        }

        /// <summary>
        /// This API is used to get the list of created tags.
        /// </summary>
        /// <param name="req"><see cref="GetTagsRequest"/></param>
        /// <returns><see cref="GetTagsResponse"/></returns>
        public GetTagsResponse GetTagsSync(GetTagsRequest req)
        {
            return InternalRequestAsync<GetTagsResponse>(req, "GetTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify all tags associated with a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags");
        }

        /// <summary>
        /// This API is used to modify all tags associated with a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public ModifyResourceTagsResponse ModifyResourceTagsSync(ModifyResourceTagsRequest req)
        {
            return InternalRequestAsync<ModifyResourceTagsResponse>(req, "ModifyResourceTags")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the tag value corresponding to a tag key associated with multiple resources.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagValueRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagValueResponse"/></returns>
        public Task<ModifyResourcesTagValueResponse> ModifyResourcesTagValue(ModifyResourcesTagValueRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagValueResponse>(req, "ModifyResourcesTagValue");
        }

        /// <summary>
        /// This API is used to modify the tag value corresponding to a tag key associated with multiple resources.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourcesTagValueRequest"/></param>
        /// <returns><see cref="ModifyResourcesTagValueResponse"/></returns>
        public ModifyResourcesTagValueResponse ModifyResourcesTagValueSync(ModifyResourcesTagValueRequest req)
        {
            return InternalRequestAsync<ModifyResourcesTagValueResponse>(req, "ModifyResourcesTagValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create and bind a tag uniformly to multiple specified resources of multiple Tencent Cloud services.
        /// </summary>
        /// <param name="req"><see cref="TagResourcesRequest"/></param>
        /// <returns><see cref="TagResourcesResponse"/></returns>
        public Task<TagResourcesResponse> TagResources(TagResourcesRequest req)
        {
            return InternalRequestAsync<TagResourcesResponse>(req, "TagResources");
        }

        /// <summary>
        /// This API is used to create and bind a tag uniformly to multiple specified resources of multiple Tencent Cloud services.
        /// </summary>
        /// <param name="req"><see cref="TagResourcesRequest"/></param>
        /// <returns><see cref="TagResourcesResponse"/></returns>
        public TagResourcesResponse TagResourcesSync(TagResourcesRequest req)
        {
            return InternalRequestAsync<TagResourcesResponse>(req, "TagResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a tag uniformly from multiple specified resources of multiple Tencent Cloud services.
        /// </summary>
        /// <param name="req"><see cref="UnTagResourcesRequest"/></param>
        /// <returns><see cref="UnTagResourcesResponse"/></returns>
        public Task<UnTagResourcesResponse> UnTagResources(UnTagResourcesRequest req)
        {
            return InternalRequestAsync<UnTagResourcesResponse>(req, "UnTagResources");
        }

        /// <summary>
        /// This API is used to unbind a tag uniformly from multiple specified resources of multiple Tencent Cloud services.
        /// </summary>
        /// <param name="req"><see cref="UnTagResourcesRequest"/></param>
        /// <returns><see cref="UnTagResourcesResponse"/></returns>
        public UnTagResourcesResponse UnTagResourcesSync(UnTagResourcesRequest req)
        {
            return InternalRequestAsync<UnTagResourcesResponse>(req, "UnTagResources")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the values of tags associated with a resource (the tag key does not change).
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public Task<UpdateResourceTagValueResponse> UpdateResourceTagValue(UpdateResourceTagValueRequest req)
        {
            return InternalRequestAsync<UpdateResourceTagValueResponse>(req, "UpdateResourceTagValue");
        }

        /// <summary>
        /// This API is used to modify the values of tags associated with a resource (the tag key does not change).
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public UpdateResourceTagValueResponse UpdateResourceTagValueSync(UpdateResourceTagValueRequest req)
        {
            return InternalRequestAsync<UpdateResourceTagValueResponse>(req, "UpdateResourceTagValue")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
