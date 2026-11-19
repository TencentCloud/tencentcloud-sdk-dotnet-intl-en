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

    public class ProjectDeployment : AbstractModel
    {
        
        /// <summary>
        /// <p>Deployment ID</p>
        /// </summary>
        [JsonProperty("DeploymentId")]
        public string DeploymentId{ get; set; }

        /// <summary>
        /// <p>Project ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>Deployment state</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Build duration, in milliseconds.</p>
        /// </summary>
        [JsonProperty("BuildCost")]
        public string BuildCost{ get; set; }

        /// <summary>
        /// <p>Trigger source.</p>
        /// </summary>
        [JsonProperty("ViaMeta")]
        public string ViaMeta{ get; set; }

        /// <summary>
        /// <p>Environment slug</p>
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }

        /// <summary>
        /// <p>Branch</p>
        /// </summary>
        [JsonProperty("RepoBranch")]
        public string RepoBranch{ get; set; }

        /// <summary>
        /// <p>Submit hash</p>
        /// </summary>
        [JsonProperty("RepoCommitHash")]
        public string RepoCommitHash{ get; set; }

        /// <summary>
        /// <p>Commit description</p>
        /// </summary>
        [JsonProperty("RepoCommitMsg")]
        public string RepoCommitMsg{ get; set; }

        /// <summary>
        /// <p>Preview address</p>
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }

        /// <summary>
        /// <p>Address of a cover</p>
        /// </summary>
        [JsonProperty("CoverUrl")]
        public string CoverUrl{ get; set; }

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
        /// <p>Repository address used for this deployment</p>
        /// </summary>
        [JsonProperty("DplRepoUrl")]
        public string DplRepoUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeploymentId", this.DeploymentId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BuildCost", this.BuildCost);
            this.SetParamSimple(map, prefix + "ViaMeta", this.ViaMeta);
            this.SetParamSimple(map, prefix + "Env", this.Env);
            this.SetParamSimple(map, prefix + "RepoBranch", this.RepoBranch);
            this.SetParamSimple(map, prefix + "RepoCommitHash", this.RepoCommitHash);
            this.SetParamSimple(map, prefix + "RepoCommitMsg", this.RepoCommitMsg);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamSimple(map, prefix + "CoverUrl", this.CoverUrl);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "DplRepoUrl", this.DplRepoUrl);
        }
    }
}

