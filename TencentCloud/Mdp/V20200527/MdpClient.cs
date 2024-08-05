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

namespace TencentCloud.Mdp.V20200527
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mdp.V20200527.Models;

   public class MdpClient : AbstractClient{

       private const string endpoint = "mdp.tencentcloudapi.com";
       private const string version = "2020-05-27";
       private const string sdkVersion = "SDK_NET_3.0.954";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MdpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MdpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to bind an LVB domain name to a channel.
        /// </summary>
        /// <param name="req"><see cref="BindNewLVBDomainWithChannelRequest"/></param>
        /// <returns><see cref="BindNewLVBDomainWithChannelResponse"/></returns>
        public Task<BindNewLVBDomainWithChannelResponse> BindNewLVBDomainWithChannel(BindNewLVBDomainWithChannelRequest req)
        {
            return InternalRequestAsync<BindNewLVBDomainWithChannelResponse>(req, "BindNewLVBDomainWithChannel");
        }

        /// <summary>
        /// This API is used to bind an LVB domain name to a channel.
        /// </summary>
        /// <param name="req"><see cref="BindNewLVBDomainWithChannelRequest"/></param>
        /// <returns><see cref="BindNewLVBDomainWithChannelResponse"/></returns>
        public BindNewLVBDomainWithChannelResponse BindNewLVBDomainWithChannelSync(BindNewLVBDomainWithChannelRequest req)
        {
            return InternalRequestAsync<BindNewLVBDomainWithChannelResponse>(req, "BindNewLVBDomainWithChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelResponse"/></returns>
        public Task<CreateStreamPackageChannelResponse> CreateStreamPackageChannel(CreateStreamPackageChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageChannelResponse>(req, "CreateStreamPackageChannel");
        }

        /// <summary>
        /// This API is used to create a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelResponse"/></returns>
        public CreateStreamPackageChannelResponse CreateStreamPackageChannelSync(CreateStreamPackageChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageChannelResponse>(req, "CreateStreamPackageChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create an endpoint on a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelEndpointResponse"/></returns>
        public Task<CreateStreamPackageChannelEndpointResponse> CreateStreamPackageChannelEndpoint(CreateStreamPackageChannelEndpointRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageChannelEndpointResponse>(req, "CreateStreamPackageChannelEndpoint");
        }

        /// <summary>
        /// This API is used to create an endpoint on a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="CreateStreamPackageChannelEndpointResponse"/></returns>
        public CreateStreamPackageChannelEndpointResponse CreateStreamPackageChannelEndpointSync(CreateStreamPackageChannelEndpointRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageChannelEndpointResponse>(req, "CreateStreamPackageChannelEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageHarvestJobRequest"/></param>
        /// <returns><see cref="CreateStreamPackageHarvestJobResponse"/></returns>
        public Task<CreateStreamPackageHarvestJobResponse> CreateStreamPackageHarvestJob(CreateStreamPackageHarvestJobRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageHarvestJobResponse>(req, "CreateStreamPackageHarvestJob");
        }

        /// <summary>
        /// Create HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageHarvestJobRequest"/></param>
        /// <returns><see cref="CreateStreamPackageHarvestJobResponse"/></returns>
        public CreateStreamPackageHarvestJobResponse CreateStreamPackageHarvestJobSync(CreateStreamPackageHarvestJobRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageHarvestJobResponse>(req, "CreateStreamPackageHarvestJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete endpoints from a StreamPackage channel in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelEndpointsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelEndpointsResponse"/></returns>
        public Task<DeleteStreamPackageChannelEndpointsResponse> DeleteStreamPackageChannelEndpoints(DeleteStreamPackageChannelEndpointsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageChannelEndpointsResponse>(req, "DeleteStreamPackageChannelEndpoints");
        }

        /// <summary>
        /// This API is used to delete endpoints from a StreamPackage channel in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelEndpointsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelEndpointsResponse"/></returns>
        public DeleteStreamPackageChannelEndpointsResponse DeleteStreamPackageChannelEndpointsSync(DeleteStreamPackageChannelEndpointsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageChannelEndpointsResponse>(req, "DeleteStreamPackageChannelEndpoints")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to delete StreamPackage channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelsResponse"/></returns>
        public Task<DeleteStreamPackageChannelsResponse> DeleteStreamPackageChannels(DeleteStreamPackageChannelsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageChannelsResponse>(req, "DeleteStreamPackageChannels");
        }

        /// <summary>
        /// This API is used to delete StreamPackage channels in batches.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageChannelsResponse"/></returns>
        public DeleteStreamPackageChannelsResponse DeleteStreamPackageChannelsSync(DeleteStreamPackageChannelsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageChannelsResponse>(req, "DeleteStreamPackageChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageHarvestJobRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageHarvestJobResponse"/></returns>
        public Task<DeleteStreamPackageHarvestJobResponse> DeleteStreamPackageHarvestJob(DeleteStreamPackageHarvestJobRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageHarvestJobResponse>(req, "DeleteStreamPackageHarvestJob");
        }

        /// <summary>
        /// Delete HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageHarvestJobRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageHarvestJobResponse"/></returns>
        public DeleteStreamPackageHarvestJobResponse DeleteStreamPackageHarvestJobSync(DeleteStreamPackageHarvestJobRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageHarvestJobResponse>(req, "DeleteStreamPackageHarvestJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Deleting HarvestJobs in Batch.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageHarvestJobsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageHarvestJobsResponse"/></returns>
        public Task<DeleteStreamPackageHarvestJobsResponse> DeleteStreamPackageHarvestJobs(DeleteStreamPackageHarvestJobsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageHarvestJobsResponse>(req, "DeleteStreamPackageHarvestJobs");
        }

        /// <summary>
        /// Deleting HarvestJobs in Batch.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageHarvestJobsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageHarvestJobsResponse"/></returns>
        public DeleteStreamPackageHarvestJobsResponse DeleteStreamPackageHarvestJobsSync(DeleteStreamPackageHarvestJobsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageHarvestJobsResponse>(req, "DeleteStreamPackageHarvestJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelResponse"/></returns>
        public Task<DescribeStreamPackageChannelResponse> DescribeStreamPackageChannel(DescribeStreamPackageChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageChannelResponse>(req, "DescribeStreamPackageChannel");
        }

        /// <summary>
        /// This API is used to query the information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelResponse"/></returns>
        public DescribeStreamPackageChannelResponse DescribeStreamPackageChannelSync(DescribeStreamPackageChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageChannelResponse>(req, "DescribeStreamPackageChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query the information of multiple StreamPackage channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelsResponse"/></returns>
        public Task<DescribeStreamPackageChannelsResponse> DescribeStreamPackageChannels(DescribeStreamPackageChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageChannelsResponse>(req, "DescribeStreamPackageChannels");
        }

        /// <summary>
        /// This API is used to query the information of multiple StreamPackage channels.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageChannelsResponse"/></returns>
        public DescribeStreamPackageChannelsResponse DescribeStreamPackageChannelsSync(DescribeStreamPackageChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageChannelsResponse>(req, "DescribeStreamPackageChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageHarvestJobRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageHarvestJobResponse"/></returns>
        public Task<DescribeStreamPackageHarvestJobResponse> DescribeStreamPackageHarvestJob(DescribeStreamPackageHarvestJobRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageHarvestJobResponse>(req, "DescribeStreamPackageHarvestJob");
        }

        /// <summary>
        /// Query HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageHarvestJobRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageHarvestJobResponse"/></returns>
        public DescribeStreamPackageHarvestJobResponse DescribeStreamPackageHarvestJobSync(DescribeStreamPackageHarvestJobRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageHarvestJobResponse>(req, "DescribeStreamPackageHarvestJob")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch query HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageHarvestJobsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageHarvestJobsResponse"/></returns>
        public Task<DescribeStreamPackageHarvestJobsResponse> DescribeStreamPackageHarvestJobs(DescribeStreamPackageHarvestJobsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageHarvestJobsResponse>(req, "DescribeStreamPackageHarvestJobs");
        }

        /// <summary>
        /// Batch query HarvestJob.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageHarvestJobsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageHarvestJobsResponse"/></returns>
        public DescribeStreamPackageHarvestJobsResponse DescribeStreamPackageHarvestJobsSync(DescribeStreamPackageHarvestJobsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageHarvestJobsResponse>(req, "DescribeStreamPackageHarvestJobs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelResponse"/></returns>
        public Task<ModifyStreamPackageChannelResponse> ModifyStreamPackageChannel(ModifyStreamPackageChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageChannelResponse>(req, "ModifyStreamPackageChannel");
        }

        /// <summary>
        /// This API is used to modify a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelResponse"/></returns>
        public ModifyStreamPackageChannelResponse ModifyStreamPackageChannelSync(ModifyStreamPackageChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageChannelResponse>(req, "ModifyStreamPackageChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify an endpoint of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelEndpointResponse"/></returns>
        public Task<ModifyStreamPackageChannelEndpointResponse> ModifyStreamPackageChannelEndpoint(ModifyStreamPackageChannelEndpointRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageChannelEndpointResponse>(req, "ModifyStreamPackageChannelEndpoint");
        }

        /// <summary>
        /// This API is used to modify an endpoint of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelEndpointRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelEndpointResponse"/></returns>
        public ModifyStreamPackageChannelEndpointResponse ModifyStreamPackageChannelEndpointSync(ModifyStreamPackageChannelEndpointRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageChannelEndpointResponse>(req, "ModifyStreamPackageChannelEndpoint")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to modify the input authentication information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelInputAuthInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelInputAuthInfoResponse"/></returns>
        public Task<ModifyStreamPackageChannelInputAuthInfoResponse> ModifyStreamPackageChannelInputAuthInfo(ModifyStreamPackageChannelInputAuthInfoRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageChannelInputAuthInfoResponse>(req, "ModifyStreamPackageChannelInputAuthInfo");
        }

        /// <summary>
        /// This API is used to modify the input authentication information of a StreamPackage channel.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageChannelInputAuthInfoRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageChannelInputAuthInfoResponse"/></returns>
        public ModifyStreamPackageChannelInputAuthInfoResponse ModifyStreamPackageChannelInputAuthInfoSync(ModifyStreamPackageChannelInputAuthInfoRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageChannelInputAuthInfoResponse>(req, "ModifyStreamPackageChannelInputAuthInfo")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to unbind a CDN playback domain name from a channel.
        /// </summary>
        /// <param name="req"><see cref="UnbindCdnDomainWithChannelRequest"/></param>
        /// <returns><see cref="UnbindCdnDomainWithChannelResponse"/></returns>
        public Task<UnbindCdnDomainWithChannelResponse> UnbindCdnDomainWithChannel(UnbindCdnDomainWithChannelRequest req)
        {
            return InternalRequestAsync<UnbindCdnDomainWithChannelResponse>(req, "UnbindCdnDomainWithChannel");
        }

        /// <summary>
        /// This API is used to unbind a CDN playback domain name from a channel.
        /// </summary>
        /// <param name="req"><see cref="UnbindCdnDomainWithChannelRequest"/></param>
        /// <returns><see cref="UnbindCdnDomainWithChannelResponse"/></returns>
        public UnbindCdnDomainWithChannelResponse UnbindCdnDomainWithChannelSync(UnbindCdnDomainWithChannelRequest req)
        {
            return InternalRequestAsync<UnbindCdnDomainWithChannelResponse>(req, "UnbindCdnDomainWithChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
