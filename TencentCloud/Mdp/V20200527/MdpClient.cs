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
       private const string sdkVersion = "SDK_NET_3.0.1077";

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
        /// Create a linear assembly channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageLinearAssemblyChannelResponse"/></returns>
        public Task<CreateStreamPackageLinearAssemblyChannelResponse> CreateStreamPackageLinearAssemblyChannel(CreateStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageLinearAssemblyChannelResponse>(req, "CreateStreamPackageLinearAssemblyChannel");
        }

        /// <summary>
        /// Create a linear assembly channel.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageLinearAssemblyChannelResponse"/></returns>
        public CreateStreamPackageLinearAssemblyChannelResponse CreateStreamPackageLinearAssemblyChannelSync(CreateStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageLinearAssemblyChannelResponse>(req, "CreateStreamPackageLinearAssemblyChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a linear assembly program.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="CreateStreamPackageLinearAssemblyProgramResponse"/></returns>
        public Task<CreateStreamPackageLinearAssemblyProgramResponse> CreateStreamPackageLinearAssemblyProgram(CreateStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageLinearAssemblyProgramResponse>(req, "CreateStreamPackageLinearAssemblyProgram");
        }

        /// <summary>
        /// Create a linear assembly program.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="CreateStreamPackageLinearAssemblyProgramResponse"/></returns>
        public CreateStreamPackageLinearAssemblyProgramResponse CreateStreamPackageLinearAssemblyProgramSync(CreateStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageLinearAssemblyProgramResponse>(req, "CreateStreamPackageLinearAssemblyProgram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// CreateStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageSSAIChannelResponse"/></returns>
        public Task<CreateStreamPackageSSAIChannelResponse> CreateStreamPackageSSAIChannel(CreateStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageSSAIChannelResponse>(req, "CreateStreamPackageSSAIChannel");
        }

        /// <summary>
        /// CreateStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="CreateStreamPackageSSAIChannelResponse"/></returns>
        public CreateStreamPackageSSAIChannelResponse CreateStreamPackageSSAIChannelSync(CreateStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageSSAIChannelResponse>(req, "CreateStreamPackageSSAIChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create channel linear assembly Source.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageSourceRequest"/></param>
        /// <returns><see cref="CreateStreamPackageSourceResponse"/></returns>
        public Task<CreateStreamPackageSourceResponse> CreateStreamPackageSource(CreateStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageSourceResponse>(req, "CreateStreamPackageSource");
        }

        /// <summary>
        /// Create channel linear assembly Source.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageSourceRequest"/></param>
        /// <returns><see cref="CreateStreamPackageSourceResponse"/></returns>
        public CreateStreamPackageSourceResponse CreateStreamPackageSourceSync(CreateStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageSourceResponse>(req, "CreateStreamPackageSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create Linear Assembly SourceLocation.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="CreateStreamPackageSourceLocationResponse"/></returns>
        public Task<CreateStreamPackageSourceLocationResponse> CreateStreamPackageSourceLocation(CreateStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageSourceLocationResponse>(req, "CreateStreamPackageSourceLocation");
        }

        /// <summary>
        /// Create Linear Assembly SourceLocation.
        /// </summary>
        /// <param name="req"><see cref="CreateStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="CreateStreamPackageSourceLocationResponse"/></returns>
        public CreateStreamPackageSourceLocationResponse CreateStreamPackageSourceLocationSync(CreateStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<CreateStreamPackageSourceLocationResponse>(req, "CreateStreamPackageSourceLocation")
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
        /// Delete channel linear assemblyChannel.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyChannelResponse"/></returns>
        public Task<DeleteStreamPackageLinearAssemblyChannelResponse> DeleteStreamPackageLinearAssemblyChannel(DeleteStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyChannelResponse>(req, "DeleteStreamPackageLinearAssemblyChannel");
        }

        /// <summary>
        /// Delete channel linear assemblyChannel.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyChannelResponse"/></returns>
        public DeleteStreamPackageLinearAssemblyChannelResponse DeleteStreamPackageLinearAssemblyChannelSync(DeleteStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyChannelResponse>(req, "DeleteStreamPackageLinearAssemblyChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete channels in batches and linearly assemble channels.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyChannelsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyChannelsResponse"/></returns>
        public Task<DeleteStreamPackageLinearAssemblyChannelsResponse> DeleteStreamPackageLinearAssemblyChannels(DeleteStreamPackageLinearAssemblyChannelsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyChannelsResponse>(req, "DeleteStreamPackageLinearAssemblyChannels");
        }

        /// <summary>
        /// Delete channels in batches and linearly assemble channels.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyChannelsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyChannelsResponse"/></returns>
        public DeleteStreamPackageLinearAssemblyChannelsResponse DeleteStreamPackageLinearAssemblyChannelsSync(DeleteStreamPackageLinearAssemblyChannelsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyChannelsResponse>(req, "DeleteStreamPackageLinearAssemblyChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete Channel Linear Assembly Program.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyProgramResponse"/></returns>
        public Task<DeleteStreamPackageLinearAssemblyProgramResponse> DeleteStreamPackageLinearAssemblyProgram(DeleteStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyProgramResponse>(req, "DeleteStreamPackageLinearAssemblyProgram");
        }

        /// <summary>
        /// Delete Channel Linear Assembly Program.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyProgramResponse"/></returns>
        public DeleteStreamPackageLinearAssemblyProgramResponse DeleteStreamPackageLinearAssemblyProgramSync(DeleteStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyProgramResponse>(req, "DeleteStreamPackageLinearAssemblyProgram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch deletion of channels linear assembly program.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyProgramsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyProgramsResponse"/></returns>
        public Task<DeleteStreamPackageLinearAssemblyProgramsResponse> DeleteStreamPackageLinearAssemblyPrograms(DeleteStreamPackageLinearAssemblyProgramsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyProgramsResponse>(req, "DeleteStreamPackageLinearAssemblyPrograms");
        }

        /// <summary>
        /// Batch deletion of channels linear assembly program.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageLinearAssemblyProgramsRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageLinearAssemblyProgramsResponse"/></returns>
        public DeleteStreamPackageLinearAssemblyProgramsResponse DeleteStreamPackageLinearAssemblyProgramsSync(DeleteStreamPackageLinearAssemblyProgramsRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageLinearAssemblyProgramsResponse>(req, "DeleteStreamPackageLinearAssemblyPrograms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DeleteStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageSSAIChannelResponse"/></returns>
        public Task<DeleteStreamPackageSSAIChannelResponse> DeleteStreamPackageSSAIChannel(DeleteStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageSSAIChannelResponse>(req, "DeleteStreamPackageSSAIChannel");
        }

        /// <summary>
        /// DeleteStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageSSAIChannelResponse"/></returns>
        public DeleteStreamPackageSSAIChannelResponse DeleteStreamPackageSSAIChannelSync(DeleteStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageSSAIChannelResponse>(req, "DeleteStreamPackageSSAIChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete channel linear assembly Source.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageSourceRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageSourceResponse"/></returns>
        public Task<DeleteStreamPackageSourceResponse> DeleteStreamPackageSource(DeleteStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageSourceResponse>(req, "DeleteStreamPackageSource");
        }

        /// <summary>
        /// Delete channel linear assembly Source.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageSourceRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageSourceResponse"/></returns>
        public DeleteStreamPackageSourceResponse DeleteStreamPackageSourceSync(DeleteStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageSourceResponse>(req, "DeleteStreamPackageSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Batch delete media packaging SourceLocation.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageSourceLocationResponse"/></returns>
        public Task<DeleteStreamPackageSourceLocationResponse> DeleteStreamPackageSourceLocation(DeleteStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageSourceLocationResponse>(req, "DeleteStreamPackageSourceLocation");
        }

        /// <summary>
        /// Batch delete media packaging SourceLocation.
        /// </summary>
        /// <param name="req"><see cref="DeleteStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="DeleteStreamPackageSourceLocationResponse"/></returns>
        public DeleteStreamPackageSourceLocationResponse DeleteStreamPackageSourceLocationSync(DeleteStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<DeleteStreamPackageSourceLocationResponse>(req, "DeleteStreamPackageSourceLocation")
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
        /// Query channel linear assembly Channel information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyChannelResponse"/></returns>
        public Task<DescribeStreamPackageLinearAssemblyChannelResponse> DescribeStreamPackageLinearAssemblyChannel(DescribeStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyChannelResponse>(req, "DescribeStreamPackageLinearAssemblyChannel");
        }

        /// <summary>
        /// Query channel linear assembly Channel information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyChannelResponse"/></returns>
        public DescribeStreamPackageLinearAssemblyChannelResponse DescribeStreamPackageLinearAssemblyChannelSync(DescribeStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyChannelResponse>(req, "DescribeStreamPackageLinearAssemblyChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query linear assembly channel alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyChannelAlertsResponse"/></returns>
        public Task<DescribeStreamPackageLinearAssemblyChannelAlertsResponse> DescribeStreamPackageLinearAssemblyChannelAlerts(DescribeStreamPackageLinearAssemblyChannelAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyChannelAlertsResponse>(req, "DescribeStreamPackageLinearAssemblyChannelAlerts");
        }

        /// <summary>
        /// Query linear assembly channel alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyChannelAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyChannelAlertsResponse"/></returns>
        public DescribeStreamPackageLinearAssemblyChannelAlertsResponse DescribeStreamPackageLinearAssemblyChannelAlertsSync(DescribeStreamPackageLinearAssemblyChannelAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyChannelAlertsResponse>(req, "DescribeStreamPackageLinearAssemblyChannelAlerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly Channel information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyChannelsResponse"/></returns>
        public Task<DescribeStreamPackageLinearAssemblyChannelsResponse> DescribeStreamPackageLinearAssemblyChannels(DescribeStreamPackageLinearAssemblyChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyChannelsResponse>(req, "DescribeStreamPackageLinearAssemblyChannels");
        }

        /// <summary>
        /// Query channel linear assembly Channel information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyChannelsResponse"/></returns>
        public DescribeStreamPackageLinearAssemblyChannelsResponse DescribeStreamPackageLinearAssemblyChannelsSync(DescribeStreamPackageLinearAssemblyChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyChannelsResponse>(req, "DescribeStreamPackageLinearAssemblyChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly program information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyProgramResponse"/></returns>
        public Task<DescribeStreamPackageLinearAssemblyProgramResponse> DescribeStreamPackageLinearAssemblyProgram(DescribeStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyProgramResponse>(req, "DescribeStreamPackageLinearAssemblyProgram");
        }

        /// <summary>
        /// Query channel linear assembly program information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyProgramResponse"/></returns>
        public DescribeStreamPackageLinearAssemblyProgramResponse DescribeStreamPackageLinearAssemblyProgramSync(DescribeStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyProgramResponse>(req, "DescribeStreamPackageLinearAssemblyProgram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly Programl assembly scheduling information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyProgramSchedulesRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyProgramSchedulesResponse"/></returns>
        public Task<DescribeStreamPackageLinearAssemblyProgramSchedulesResponse> DescribeStreamPackageLinearAssemblyProgramSchedules(DescribeStreamPackageLinearAssemblyProgramSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyProgramSchedulesResponse>(req, "DescribeStreamPackageLinearAssemblyProgramSchedules");
        }

        /// <summary>
        /// Query channel linear assembly Programl assembly scheduling information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyProgramSchedulesRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyProgramSchedulesResponse"/></returns>
        public DescribeStreamPackageLinearAssemblyProgramSchedulesResponse DescribeStreamPackageLinearAssemblyProgramSchedulesSync(DescribeStreamPackageLinearAssemblyProgramSchedulesRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyProgramSchedulesResponse>(req, "DescribeStreamPackageLinearAssemblyProgramSchedules")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly Programl information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyProgramsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyProgramsResponse"/></returns>
        public Task<DescribeStreamPackageLinearAssemblyProgramsResponse> DescribeStreamPackageLinearAssemblyPrograms(DescribeStreamPackageLinearAssemblyProgramsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyProgramsResponse>(req, "DescribeStreamPackageLinearAssemblyPrograms");
        }

        /// <summary>
        /// Query channel linear assembly Programl information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageLinearAssemblyProgramsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageLinearAssemblyProgramsResponse"/></returns>
        public DescribeStreamPackageLinearAssemblyProgramsResponse DescribeStreamPackageLinearAssemblyProgramsSync(DescribeStreamPackageLinearAssemblyProgramsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageLinearAssemblyProgramsResponse>(req, "DescribeStreamPackageLinearAssemblyPrograms")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSSAIChannelResponse"/></returns>
        public Task<DescribeStreamPackageSSAIChannelResponse> DescribeStreamPackageSSAIChannel(DescribeStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSSAIChannelResponse>(req, "DescribeStreamPackageSSAIChannel");
        }

        /// <summary>
        /// DescribeStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSSAIChannelResponse"/></returns>
        public DescribeStreamPackageSSAIChannelResponse DescribeStreamPackageSSAIChannelSync(DescribeStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSSAIChannelResponse>(req, "DescribeStreamPackageSSAIChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// DescribeStreamPackageSSAIChannels
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSSAIChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSSAIChannelsResponse"/></returns>
        public Task<DescribeStreamPackageSSAIChannelsResponse> DescribeStreamPackageSSAIChannels(DescribeStreamPackageSSAIChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSSAIChannelsResponse>(req, "DescribeStreamPackageSSAIChannels");
        }

        /// <summary>
        /// DescribeStreamPackageSSAIChannels
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSSAIChannelsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSSAIChannelsResponse"/></returns>
        public DescribeStreamPackageSSAIChannelsResponse DescribeStreamPackageSSAIChannelsSync(DescribeStreamPackageSSAIChannelsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSSAIChannelsResponse>(req, "DescribeStreamPackageSSAIChannels")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly Source information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceResponse"/></returns>
        public Task<DescribeStreamPackageSourceResponse> DescribeStreamPackageSource(DescribeStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceResponse>(req, "DescribeStreamPackageSource");
        }

        /// <summary>
        /// Query channel linear assembly Source information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceResponse"/></returns>
        public DescribeStreamPackageSourceResponse DescribeStreamPackageSourceSync(DescribeStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceResponse>(req, "DescribeStreamPackageSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly Source alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceAlertsResponse"/></returns>
        public Task<DescribeStreamPackageSourceAlertsResponse> DescribeStreamPackageSourceAlerts(DescribeStreamPackageSourceAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceAlertsResponse>(req, "DescribeStreamPackageSourceAlerts");
        }

        /// <summary>
        /// Query channel linear assembly Source alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceAlertsResponse"/></returns>
        public DescribeStreamPackageSourceAlertsResponse DescribeStreamPackageSourceAlertsSync(DescribeStreamPackageSourceAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceAlertsResponse>(req, "DescribeStreamPackageSourceAlerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly sourceLocation information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceLocationResponse"/></returns>
        public Task<DescribeStreamPackageSourceLocationResponse> DescribeStreamPackageSourceLocation(DescribeStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceLocationResponse>(req, "DescribeStreamPackageSourceLocation");
        }

        /// <summary>
        /// Query channel linear assembly sourceLocation information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceLocationResponse"/></returns>
        public DescribeStreamPackageSourceLocationResponse DescribeStreamPackageSourceLocationSync(DescribeStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceLocationResponse>(req, "DescribeStreamPackageSourceLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly Location alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceLocationAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceLocationAlertsResponse"/></returns>
        public Task<DescribeStreamPackageSourceLocationAlertsResponse> DescribeStreamPackageSourceLocationAlerts(DescribeStreamPackageSourceLocationAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceLocationAlertsResponse>(req, "DescribeStreamPackageSourceLocationAlerts");
        }

        /// <summary>
        /// Query channel linear assembly Location alarm information.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceLocationAlertsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceLocationAlertsResponse"/></returns>
        public DescribeStreamPackageSourceLocationAlertsResponse DescribeStreamPackageSourceLocationAlertsSync(DescribeStreamPackageSourceLocationAlertsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceLocationAlertsResponse>(req, "DescribeStreamPackageSourceLocationAlerts")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly SourceLocation information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceLocationsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceLocationsResponse"/></returns>
        public Task<DescribeStreamPackageSourceLocationsResponse> DescribeStreamPackageSourceLocations(DescribeStreamPackageSourceLocationsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceLocationsResponse>(req, "DescribeStreamPackageSourceLocations");
        }

        /// <summary>
        /// Query channel linear assembly SourceLocation information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourceLocationsRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourceLocationsResponse"/></returns>
        public DescribeStreamPackageSourceLocationsResponse DescribeStreamPackageSourceLocationsSync(DescribeStreamPackageSourceLocationsRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourceLocationsResponse>(req, "DescribeStreamPackageSourceLocations")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query channel linear assembly Source information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourcesRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourcesResponse"/></returns>
        public Task<DescribeStreamPackageSourcesResponse> DescribeStreamPackageSources(DescribeStreamPackageSourcesRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourcesResponse>(req, "DescribeStreamPackageSources");
        }

        /// <summary>
        /// Query channel linear assembly Source information list.
        /// </summary>
        /// <param name="req"><see cref="DescribeStreamPackageSourcesRequest"/></param>
        /// <returns><see cref="DescribeStreamPackageSourcesResponse"/></returns>
        public DescribeStreamPackageSourcesResponse DescribeStreamPackageSourcesSync(DescribeStreamPackageSourcesRequest req)
        {
            return InternalRequestAsync<DescribeStreamPackageSourcesResponse>(req, "DescribeStreamPackageSources")
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
        /// Modify channel linear assembly Channel configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageLinearAssemblyChannelResponse"/></returns>
        public Task<ModifyStreamPackageLinearAssemblyChannelResponse> ModifyStreamPackageLinearAssemblyChannel(ModifyStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageLinearAssemblyChannelResponse>(req, "ModifyStreamPackageLinearAssemblyChannel");
        }

        /// <summary>
        /// Modify channel linear assembly Channel configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageLinearAssemblyChannelResponse"/></returns>
        public ModifyStreamPackageLinearAssemblyChannelResponse ModifyStreamPackageLinearAssemblyChannelSync(ModifyStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageLinearAssemblyChannelResponse>(req, "ModifyStreamPackageLinearAssemblyChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify channel linear assembly Program configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageLinearAssemblyProgramResponse"/></returns>
        public Task<ModifyStreamPackageLinearAssemblyProgramResponse> ModifyStreamPackageLinearAssemblyProgram(ModifyStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageLinearAssemblyProgramResponse>(req, "ModifyStreamPackageLinearAssemblyProgram");
        }

        /// <summary>
        /// Modify channel linear assembly Program configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageLinearAssemblyProgramRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageLinearAssemblyProgramResponse"/></returns>
        public ModifyStreamPackageLinearAssemblyProgramResponse ModifyStreamPackageLinearAssemblyProgramSync(ModifyStreamPackageLinearAssemblyProgramRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageLinearAssemblyProgramResponse>(req, "ModifyStreamPackageLinearAssemblyProgram")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// ModifyStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageSSAIChannelResponse"/></returns>
        public Task<ModifyStreamPackageSSAIChannelResponse> ModifyStreamPackageSSAIChannel(ModifyStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageSSAIChannelResponse>(req, "ModifyStreamPackageSSAIChannel");
        }

        /// <summary>
        /// ModifyStreamPackageSSAIChannel
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageSSAIChannelRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageSSAIChannelResponse"/></returns>
        public ModifyStreamPackageSSAIChannelResponse ModifyStreamPackageSSAIChannelSync(ModifyStreamPackageSSAIChannelRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageSSAIChannelResponse>(req, "ModifyStreamPackageSSAIChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify channel linear assembly Source configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageSourceRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageSourceResponse"/></returns>
        public Task<ModifyStreamPackageSourceResponse> ModifyStreamPackageSource(ModifyStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageSourceResponse>(req, "ModifyStreamPackageSource");
        }

        /// <summary>
        /// Modify channel linear assembly Source configuration.
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageSourceRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageSourceResponse"/></returns>
        public ModifyStreamPackageSourceResponse ModifyStreamPackageSourceSync(ModifyStreamPackageSourceRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageSourceResponse>(req, "ModifyStreamPackageSource")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify channel linear assembly SourceLocation configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageSourceLocationResponse"/></returns>
        public Task<ModifyStreamPackageSourceLocationResponse> ModifyStreamPackageSourceLocation(ModifyStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageSourceLocationResponse>(req, "ModifyStreamPackageSourceLocation");
        }

        /// <summary>
        /// Modify channel linear assembly SourceLocation configuration
        /// </summary>
        /// <param name="req"><see cref="ModifyStreamPackageSourceLocationRequest"/></param>
        /// <returns><see cref="ModifyStreamPackageSourceLocationResponse"/></returns>
        public ModifyStreamPackageSourceLocationResponse ModifyStreamPackageSourceLocationSync(ModifyStreamPackageSourceLocationRequest req)
        {
            return InternalRequestAsync<ModifyStreamPackageSourceLocationResponse>(req, "ModifyStreamPackageSourceLocation")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Start Linear Assembly Channel.
        /// </summary>
        /// <param name="req"><see cref="StartStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="StartStreamPackageLinearAssemblyChannelResponse"/></returns>
        public Task<StartStreamPackageLinearAssemblyChannelResponse> StartStreamPackageLinearAssemblyChannel(StartStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<StartStreamPackageLinearAssemblyChannelResponse>(req, "StartStreamPackageLinearAssemblyChannel");
        }

        /// <summary>
        /// Start Linear Assembly Channel.
        /// </summary>
        /// <param name="req"><see cref="StartStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="StartStreamPackageLinearAssemblyChannelResponse"/></returns>
        public StartStreamPackageLinearAssemblyChannelResponse StartStreamPackageLinearAssemblyChannelSync(StartStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<StartStreamPackageLinearAssemblyChannelResponse>(req, "StartStreamPackageLinearAssemblyChannel")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Stop linear assembly channel.
        /// </summary>
        /// <param name="req"><see cref="StopStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="StopStreamPackageLinearAssemblyChannelResponse"/></returns>
        public Task<StopStreamPackageLinearAssemblyChannelResponse> StopStreamPackageLinearAssemblyChannel(StopStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<StopStreamPackageLinearAssemblyChannelResponse>(req, "StopStreamPackageLinearAssemblyChannel");
        }

        /// <summary>
        /// Stop linear assembly channel.
        /// </summary>
        /// <param name="req"><see cref="StopStreamPackageLinearAssemblyChannelRequest"/></param>
        /// <returns><see cref="StopStreamPackageLinearAssemblyChannelResponse"/></returns>
        public StopStreamPackageLinearAssemblyChannelResponse StopStreamPackageLinearAssemblyChannelSync(StopStreamPackageLinearAssemblyChannelRequest req)
        {
            return InternalRequestAsync<StopStreamPackageLinearAssemblyChannelResponse>(req, "StopStreamPackageLinearAssemblyChannel")
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
