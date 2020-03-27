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

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TagClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
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

        }

        /// <summary>
        /// This API is used to associate resources with tags.
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public async Task<AddResourceTagResponse> AddResourceTag(AddResourceTagRequest req)
        {
             JsonResponseModel<AddResourceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to associate resources with tags.
        /// </summary>
        /// <param name="req"><see cref="AddResourceTagRequest"/></param>
        /// <returns><see cref="AddResourceTagResponse"/></returns>
        public AddResourceTagResponse AddResourceTagSync(AddResourceTagRequest req)
        {
             JsonResponseModel<AddResourceTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public async Task<CreateTagResponse> CreateTag(CreateTagRequest req)
        {
             JsonResponseModel<CreateTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to create a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="CreateTagRequest"/></param>
        /// <returns><see cref="CreateTagResponse"/></returns>
        public CreateTagResponse CreateTagSync(CreateTagRequest req)
        {
             JsonResponseModel<CreateTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unassociate tags and resources.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public async Task<DeleteResourceTagResponse> DeleteResourceTag(DeleteResourceTagRequest req)
        {
             JsonResponseModel<DeleteResourceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to unassociate tags and resources.
        /// </summary>
        /// <param name="req"><see cref="DeleteResourceTagRequest"/></param>
        /// <returns><see cref="DeleteResourceTagResponse"/></returns>
        public DeleteResourceTagResponse DeleteResourceTagSync(DeleteResourceTagRequest req)
        {
             JsonResponseModel<DeleteResourceTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public async Task<DeleteTagResponse> DeleteTag(DeleteTagRequest req)
        {
             JsonResponseModel<DeleteTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to delete a tag key and tag value pair.
        /// </summary>
        /// <param name="req"><see cref="DeleteTagRequest"/></param>
        /// <returns><see cref="DeleteTagResponse"/></returns>
        public DeleteTagResponse DeleteTagSync(DeleteTagRequest req)
        {
             JsonResponseModel<DeleteTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag key and value pairs for existing resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public async Task<DescribeResourceTagsByResourceIdsResponse> DescribeResourceTagsByResourceIds(DescribeResourceTagsByResourceIdsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByResourceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTagsByResourceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByResourceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag key and value pairs for existing resources.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns><see cref="DescribeResourceTagsByResourceIdsResponse"/></returns>
        public DescribeResourceTagsByResourceIdsResponse DescribeResourceTagsByResourceIdsSync(DescribeResourceTagsByResourceIdsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByResourceIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceTagsByResourceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByResourceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query resources by tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public async Task<DescribeResourcesByTagsResponse> DescribeResourcesByTags(DescribeResourcesByTagsRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourcesByTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query resources by tags.
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns><see cref="DescribeResourcesByTagsResponse"/></returns>
        public DescribeResourcesByTagsResponse DescribeResourcesByTagsSync(DescribeResourcesByTagsRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourcesByTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag keys in an existing tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public async Task<DescribeTagKeysResponse> DescribeTagKeys(DescribeTagKeysRequest req)
        {
             JsonResponseModel<DescribeTagKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag keys in an existing tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagKeysRequest"/></param>
        /// <returns><see cref="DescribeTagKeysResponse"/></returns>
        public DescribeTagKeysResponse DescribeTagKeysSync(DescribeTagKeysRequest req)
        {
             JsonResponseModel<DescribeTagKeysResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag values in an existing tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public async Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
             JsonResponseModel<DescribeTagValuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query tag values in an existing tag list.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagValuesRequest"/></param>
        /// <returns><see cref="DescribeTagValuesResponse"/></returns>
        public DescribeTagValuesResponse DescribeTagValuesSync(DescribeTagValuesRequest req)
        {
             JsonResponseModel<DescribeTagValuesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTagValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query existing tag lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public async Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to query existing tag lists.
        /// </summary>
        /// <param name="req"><see cref="DescribeTagsRequest"/></param>
        /// <returns><see cref="DescribeTagsResponse"/></returns>
        public DescribeTagsResponse DescribeTagsSync(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify all tags associated with a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public async Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
             JsonResponseModel<ModifyResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify all tags associated with a resource.
        /// </summary>
        /// <param name="req"><see cref="ModifyResourceTagsRequest"/></param>
        /// <returns><see cref="ModifyResourceTagsResponse"/></returns>
        public ModifyResourceTagsResponse ModifyResourceTagsSync(ModifyResourceTagsRequest req)
        {
             JsonResponseModel<ModifyResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the values of tags associated with a resource (the tag key does not change).
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public async Task<UpdateResourceTagValueResponse> UpdateResourceTagValue(UpdateResourceTagValueRequest req)
        {
             JsonResponseModel<UpdateResourceTagValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateResourceTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateResourceTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// This API is used to modify the values of tags associated with a resource (the tag key does not change).
        /// </summary>
        /// <param name="req"><see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns><see cref="UpdateResourceTagValueResponse"/></returns>
        public UpdateResourceTagValueResponse UpdateResourceTagValueSync(UpdateResourceTagValueRequest req)
        {
             JsonResponseModel<UpdateResourceTagValueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateResourceTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateResourceTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
