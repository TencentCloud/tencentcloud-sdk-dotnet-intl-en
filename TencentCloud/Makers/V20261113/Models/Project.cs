/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Makers.V20261113.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Project : AbstractModel
    {
        
        /// <summary>
        /// <p>Project ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>Project name.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Project status. Normal, Ban, Unlink, Process, Pending, Offline</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Site ID</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Acceleration region. mainland, overseas, global</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Code source. Github, Gitee, Coding, Upload, Gitlab, Bitbucket, Cnb</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>Create Source. Template, Custom, CLI, Guest</p>
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// <p>Preset domain name.</p>
        /// </summary>
        [JsonProperty("PresetDomain")]
        public string PresetDomain{ get; set; }

        /// <summary>
        /// <p>Preset domain name status</p>
        /// </summary>
        [JsonProperty("PresetDomainStatus")]
        public string PresetDomainStatus{ get; set; }

        /// <summary>
        /// <p>Project root directory</p>
        /// </summary>
        [JsonProperty("RootDir")]
        public string RootDir{ get; set; }

        /// <summary>
        /// <p>Build artifact directory</p>
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// <p>Build command</p>
        /// </summary>
        [JsonProperty("BuildCmd")]
        public string BuildCmd{ get; set; }

        /// <summary>
        /// <p>Installation command</p>
        /// </summary>
        [JsonProperty("InstallCmd")]
        public string InstallCmd{ get; set; }

        /// <summary>
        /// <p>Framework</p>
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// <p>Node.js version</p>
        /// </summary>
        [JsonProperty("NodejsVersion")]
        public string NodejsVersion{ get; set; }

        /// <summary>
        /// <p>Repository address</p>
        /// </summary>
        [JsonProperty("RepoUrl")]
        public string RepoUrl{ get; set; }

        /// <summary>
        /// <p>Repository owner</p>
        /// </summary>
        [JsonProperty("RepoOwner")]
        public string RepoOwner{ get; set; }

        /// <summary>
        /// <p>Repository name</p>
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// <p>Production branch</p>
        /// </summary>
        [JsonProperty("RepoBranch")]
        public string RepoBranch{ get; set; }

        /// <summary>
        /// <p>Preview Branch</p>
        /// </summary>
        [JsonProperty("RepoPreBranches")]
        public string[] RepoPreBranches{ get; set; }

        /// <summary>
        /// <p>Deployment region</p>
        /// </summary>
        [JsonProperty("Regions")]
        public Regions Regions{ get; set; }

        /// <summary>
        /// <p>Environment variable.</p>
        /// </summary>
        [JsonProperty("EnvVars")]
        public ProjectEnvVar[] EnvVars{ get; set; }

        /// <summary>
        /// <p>Custom domain name</p>
        /// </summary>
        [JsonProperty("CustomDomains")]
        public CustomDomainItem[] CustomDomains{ get; set; }

        /// <summary>
        /// <p>Last deployment</p>
        /// </summary>
        [JsonProperty("Deployment")]
        public ProjectDeployment Deployment{ get; set; }

        /// <summary>
        /// <p>Whether it is an Agent project. 1: yes, 0: no</p>
        /// </summary>
        [JsonProperty("IsAgent")]
        public long? IsAgent{ get; set; }

        /// <summary>
        /// <p>Agent framework. Non-Agent project is empty</p>
        /// </summary>
        [JsonProperty("AgentFramework")]
        public string AgentFramework{ get; set; }

        /// <summary>
        /// <p>Whether it hits a user-level wildcard domain name. 1: yes, 0: no</p>
        /// </summary>
        [JsonProperty("IsTld")]
        public long? IsTld{ get; set; }

        /// <summary>
        /// <p>Creation time.</p>
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// <p>Update time.</p>
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "PresetDomain", this.PresetDomain);
            this.SetParamSimple(map, prefix + "PresetDomainStatus", this.PresetDomainStatus);
            this.SetParamSimple(map, prefix + "RootDir", this.RootDir);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamSimple(map, prefix + "BuildCmd", this.BuildCmd);
            this.SetParamSimple(map, prefix + "InstallCmd", this.InstallCmd);
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamSimple(map, prefix + "NodejsVersion", this.NodejsVersion);
            this.SetParamSimple(map, prefix + "RepoUrl", this.RepoUrl);
            this.SetParamSimple(map, prefix + "RepoOwner", this.RepoOwner);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "RepoBranch", this.RepoBranch);
            this.SetParamArraySimple(map, prefix + "RepoPreBranches.", this.RepoPreBranches);
            this.SetParamObj(map, prefix + "Regions.", this.Regions);
            this.SetParamArrayObj(map, prefix + "EnvVars.", this.EnvVars);
            this.SetParamArrayObj(map, prefix + "CustomDomains.", this.CustomDomains);
            this.SetParamObj(map, prefix + "Deployment.", this.Deployment);
            this.SetParamSimple(map, prefix + "IsAgent", this.IsAgent);
            this.SetParamSimple(map, prefix + "AgentFramework", this.AgentFramework);
            this.SetParamSimple(map, prefix + "IsTld", this.IsTld);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
        }
    }
}

