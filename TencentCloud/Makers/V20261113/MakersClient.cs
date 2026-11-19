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

namespace TencentCloud.Makers.V20261113
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Makers.V20261113.Models;

   public class MakersClient : AbstractClient{

       private const string endpoint = "makers.intl.tencentcloudapi.com";
       private const string version = "2026-11-13";
       private const string sdkVersion = "SDK_NET_3.0.1429";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MakersClient(Credential credential, string region)
            : this(credential, region, new ClientProfile { Language = Language.EN_US })
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MakersClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {
            SdkVersion = sdkVersion;
        }

        /// <summary>
        /// This API is used to create a deployment. When uploading an artifact, pass Upload for ViaMeta and Provider, and pass the path of the uploaded object for TempBucketPath.
        /// </summary>
        /// <param name="req"><see cref="CreateDeploymentRequest"/></param>
        /// <returns><see cref="CreateDeploymentResponse"/></returns>
        public Task<CreateDeploymentResponse> CreateDeployment(CreateDeploymentRequest req)
        {
            return InternalRequestAsync<CreateDeploymentResponse>(req, "CreateDeployment");
        }

        /// <summary>
        /// This API is used to create a deployment. When uploading an artifact, pass Upload for ViaMeta and Provider, and pass the path of the uploaded object for TempBucketPath.
        /// </summary>
        /// <param name="req"><see cref="CreateDeploymentRequest"/></param>
        /// <returns><see cref="CreateDeploymentResponse"/></returns>
        public CreateDeploymentResponse CreateDeploymentSync(CreateDeploymentRequest req)
        {
            return InternalRequestAsync<CreateDeploymentResponse>(req, "CreateDeployment")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to create a project. When uploading an artifact, pass Upload for Provider and Custom for Channel.
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public Task<CreateProjectResponse> CreateProject(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject");
        }

        /// <summary>
        /// This API is used to create a project. When uploading an artifact, pass Upload for Provider and Custom for Channel.
        /// </summary>
        /// <param name="req"><see cref="CreateProjectRequest"/></param>
        /// <returns><see cref="CreateProjectResponse"/></returns>
        public CreateProjectResponse CreateProjectSync(CreateProjectRequest req)
        {
            return InternalRequestAsync<CreateProjectResponse>(req, "CreateProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Bind a custom domain name to a specified environment of a project.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneCustomDomainRequest"/></param>
        /// <returns><see cref="CreateZoneCustomDomainResponse"/></returns>
        public Task<CreateZoneCustomDomainResponse> CreateZoneCustomDomain(CreateZoneCustomDomainRequest req)
        {
            return InternalRequestAsync<CreateZoneCustomDomainResponse>(req, "CreateZoneCustomDomain");
        }

        /// <summary>
        /// Bind a custom domain name to a specified environment of a project.
        /// </summary>
        /// <param name="req"><see cref="CreateZoneCustomDomainRequest"/></param>
        /// <returns><see cref="CreateZoneCustomDomainResponse"/></returns>
        public CreateZoneCustomDomainResponse CreateZoneCustomDomainSync(CreateZoneCustomDomainRequest req)
        {
            return InternalRequestAsync<CreateZoneCustomDomainResponse>(req, "CreateZoneCustomDomain")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete a project. In-progress builds prevent deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public Task<DeleteProjectResponse> DeleteProject(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject");
        }

        /// <summary>
        /// Delete a project. In-progress builds prevent deletion.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectRequest"/></param>
        /// <returns><see cref="DeleteProjectResponse"/></returns>
        public DeleteProjectResponse DeleteProjectSync(DeleteProjectRequest req)
        {
            return InternalRequestAsync<DeleteProjectResponse>(req, "DeleteProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Unbind a custom domain name from a project by domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectCustomDomainsRequest"/></param>
        /// <returns><see cref="DeleteProjectCustomDomainsResponse"/></returns>
        public Task<DeleteProjectCustomDomainsResponse> DeleteProjectCustomDomains(DeleteProjectCustomDomainsRequest req)
        {
            return InternalRequestAsync<DeleteProjectCustomDomainsResponse>(req, "DeleteProjectCustomDomains");
        }

        /// <summary>
        /// Unbind a custom domain name from a project by domain name.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectCustomDomainsRequest"/></param>
        /// <returns><see cref="DeleteProjectCustomDomainsResponse"/></returns>
        public DeleteProjectCustomDomainsResponse DeleteProjectCustomDomainsSync(DeleteProjectCustomDomainsRequest req)
        {
            return InternalRequestAsync<DeleteProjectCustomDomainsResponse>(req, "DeleteProjectCustomDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete environment variables by EnvVars. Match by Id or Key. Value is required but not used for matching. You can pass any value.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectEnvsRequest"/></param>
        /// <returns><see cref="DeleteProjectEnvsResponse"/></returns>
        public Task<DeleteProjectEnvsResponse> DeleteProjectEnvs(DeleteProjectEnvsRequest req)
        {
            return InternalRequestAsync<DeleteProjectEnvsResponse>(req, "DeleteProjectEnvs");
        }

        /// <summary>
        /// Delete environment variables by EnvVars. Match by Id or Key. Value is required but not used for matching. You can pass any value.
        /// </summary>
        /// <param name="req"><see cref="DeleteProjectEnvsRequest"/></param>
        /// <returns><see cref="DeleteProjectEnvsResponse"/></returns>
        public DeleteProjectEnvsResponse DeleteProjectEnvsSync(DeleteProjectEnvsRequest req)
        {
            return InternalRequestAsync<DeleteProjectEnvsResponse>(req, "DeleteProjectEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the COS bucket, region, target path, and temporary key for uploading artifacts.
        /// </summary>
        /// <param name="req"><see cref="DescribeCosTempTokenRequest"/></param>
        /// <returns><see cref="DescribeCosTempTokenResponse"/></returns>
        public Task<DescribeCosTempTokenResponse> DescribeCosTempToken(DescribeCosTempTokenRequest req)
        {
            return InternalRequestAsync<DescribeCosTempTokenResponse>(req, "DescribeCosTempToken");
        }

        /// <summary>
        /// Get the COS bucket, region, target path, and temporary key for uploading artifacts.
        /// </summary>
        /// <param name="req"><see cref="DescribeCosTempTokenRequest"/></param>
        /// <returns><see cref="DescribeCosTempTokenResponse"/></returns>
        public DescribeCosTempTokenResponse DescribeCosTempTokenSync(DescribeCosTempTokenRequest req)
        {
            return InternalRequestAsync<DescribeCosTempTokenResponse>(req, "DescribeCosTempToken")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Return the access address of the build log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentLogRequest"/></param>
        /// <returns><see cref="DescribeDeploymentLogResponse"/></returns>
        public Task<DescribeDeploymentLogResponse> DescribeDeploymentLog(DescribeDeploymentLogRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentLogResponse>(req, "DescribeDeploymentLog");
        }

        /// <summary>
        /// Return the access address of the build log.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentLogRequest"/></param>
        /// <returns><see cref="DescribeDeploymentLogResponse"/></returns>
        public DescribeDeploymentLogResponse DescribeDeploymentLogSync(DescribeDeploymentLogRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentLogResponse>(req, "DescribeDeploymentLog")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query deployment records of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentsRequest"/></param>
        /// <returns><see cref="DescribeDeploymentsResponse"/></returns>
        public Task<DescribeDeploymentsResponse> DescribeDeployments(DescribeDeploymentsRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentsResponse>(req, "DescribeDeployments");
        }

        /// <summary>
        /// Query deployment records of a project.
        /// </summary>
        /// <param name="req"><see cref="DescribeDeploymentsRequest"/></param>
        /// <returns><see cref="DescribeDeploymentsResponse"/></returns>
        public DescribeDeploymentsResponse DescribeDeploymentsSync(DescribeDeploymentsRequest req)
        {
            return InternalRequestAsync<DescribeDeploymentsResponse>(req, "DescribeDeployments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query environments in a project, including built-in Production, Preview, and custom environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public Task<DescribeEnvironmentsResponse> DescribeEnvironments(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments");
        }

        /// <summary>
        /// Query environments in a project, including built-in Production, Preview, and custom environments.
        /// </summary>
        /// <param name="req"><see cref="DescribeEnvironmentsRequest"/></param>
        /// <returns><see cref="DescribeEnvironmentsResponse"/></returns>
        public DescribeEnvironmentsResponse DescribeEnvironmentsSync(DescribeEnvironmentsRequest req)
        {
            return InternalRequestAsync<DescribeEnvironmentsResponse>(req, "DescribeEnvironments")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Query project environment variables. If Env is not specified, return all application scopes.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectEnvsRequest"/></param>
        /// <returns><see cref="DescribeProjectEnvsResponse"/></returns>
        public Task<DescribeProjectEnvsResponse> DescribeProjectEnvs(DescribeProjectEnvsRequest req)
        {
            return InternalRequestAsync<DescribeProjectEnvsResponse>(req, "DescribeProjectEnvs");
        }

        /// <summary>
        /// Query project environment variables. If Env is not specified, return all application scopes.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectEnvsRequest"/></param>
        /// <returns><see cref="DescribeProjectEnvsResponse"/></returns>
        public DescribeProjectEnvsResponse DescribeProjectEnvsSync(DescribeProjectEnvsRequest req)
        {
            return InternalRequestAsync<DescribeProjectEnvsResponse>(req, "DescribeProjectEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// This API is used to query projects under a site by page. Offset is the page number offset, and the backend skips Offset * Limit items.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public Task<DescribeProjectsResponse> DescribeProjects(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects");
        }

        /// <summary>
        /// This API is used to query projects under a site by page. Offset is the page number offset, and the backend skips Offset * Limit items.
        /// </summary>
        /// <param name="req"><see cref="DescribeProjectsRequest"/></param>
        /// <returns><see cref="DescribeProjectsResponse"/></returns>
        public DescribeProjectsResponse DescribeProjectsSync(DescribeProjectsRequest req)
        {
            return InternalRequestAsync<DescribeProjectsResponse>(req, "DescribeProjects")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Queries the custom and preset domain names of a project under a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneCustomDomainsRequest"/></param>
        /// <returns><see cref="DescribeZoneCustomDomainsResponse"/></returns>
        public Task<DescribeZoneCustomDomainsResponse> DescribeZoneCustomDomains(DescribeZoneCustomDomainsRequest req)
        {
            return InternalRequestAsync<DescribeZoneCustomDomainsResponse>(req, "DescribeZoneCustomDomains");
        }

        /// <summary>
        /// Queries the custom and preset domain names of a project under a site.
        /// </summary>
        /// <param name="req"><see cref="DescribeZoneCustomDomainsRequest"/></param>
        /// <returns><see cref="DescribeZoneCustomDomainsResponse"/></returns>
        public DescribeZoneCustomDomainsResponse DescribeZoneCustomDomainsSync(DescribeZoneCustomDomainsRequest req)
        {
            return InternalRequestAsync<DescribeZoneCustomDomainsResponse>(req, "DescribeZoneCustomDomains")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Modify the project name and build configuration. Fields not passed retain their original values.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public Task<ModifyProjectResponse> ModifyProject(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject");
        }

        /// <summary>
        /// Modify the project name and build configuration. Fields not passed retain their original values.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectRequest"/></param>
        /// <returns><see cref="ModifyProjectResponse"/></returns>
        public ModifyProjectResponse ModifyProjectSync(ModifyProjectRequest req)
        {
            return InternalRequestAsync<ModifyProjectResponse>(req, "ModifyProject")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Write environment variables based on the passed-in EnvVars.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectEnvsRequest"/></param>
        /// <returns><see cref="ModifyProjectEnvsResponse"/></returns>
        public Task<ModifyProjectEnvsResponse> ModifyProjectEnvs(ModifyProjectEnvsRequest req)
        {
            return InternalRequestAsync<ModifyProjectEnvsResponse>(req, "ModifyProjectEnvs");
        }

        /// <summary>
        /// Write environment variables based on the passed-in EnvVars.
        /// </summary>
        /// <param name="req"><see cref="ModifyProjectEnvsRequest"/></param>
        /// <returns><see cref="ModifyProjectEnvsResponse"/></returns>
        public ModifyProjectEnvsResponse ModifyProjectEnvsSync(ModifyProjectEnvsRequest req)
        {
            return InternalRequestAsync<ModifyProjectEnvsResponse>(req, "ModifyProjectEnvs")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Switch a bound custom domain name to another environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCustomDomainEnvRequest"/></param>
        /// <returns><see cref="ModifyZoneCustomDomainEnvResponse"/></returns>
        public Task<ModifyZoneCustomDomainEnvResponse> ModifyZoneCustomDomainEnv(ModifyZoneCustomDomainEnvRequest req)
        {
            return InternalRequestAsync<ModifyZoneCustomDomainEnvResponse>(req, "ModifyZoneCustomDomainEnv");
        }

        /// <summary>
        /// Switch a bound custom domain name to another environment.
        /// </summary>
        /// <param name="req"><see cref="ModifyZoneCustomDomainEnvRequest"/></param>
        /// <returns><see cref="ModifyZoneCustomDomainEnvResponse"/></returns>
        public ModifyZoneCustomDomainEnvResponse ModifyZoneCustomDomainEnvSync(ModifyZoneCustomDomainEnvRequest req)
        {
            return InternalRequestAsync<ModifyZoneCustomDomainEnvResponse>(req, "ModifyZoneCustomDomainEnv")
                .ConfigureAwait(false).GetAwaiter().GetResult();
        }

    }
}
