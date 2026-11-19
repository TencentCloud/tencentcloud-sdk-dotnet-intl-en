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

    public class CreateDeploymentRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Makers site ID</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Project ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>Trigger source. Github, ReDeploy, Api, Webhook, Upload, Coding, Gitee, Gitlab</p>
        /// </summary>
        [JsonProperty("ViaMeta")]
        public string ViaMeta{ get; set; }

        /// <summary>
        /// <p>Environment slug. Production, Preview, or custom environment</p>
        /// </summary>
        [JsonProperty("Env")]
        public string Env{ get; set; }

        /// <summary>
        /// <p>Code source. For upload artifact, pass Upload.</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>Artifact type. Zip or Folder</p>
        /// </summary>
        [JsonProperty("DistType")]
        public string DistType{ get; set; }

        /// <summary>
        /// <p>Object path of the uploaded artifact in the temporary bucket</p>
        /// </summary>
        [JsonProperty("TempBucketPath")]
        public string TempBucketPath{ get; set; }

        /// <summary>
        /// <p>Build branch</p>
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
        /// <p>Build source</p>
        /// </summary>
        [JsonProperty("BuildFrom")]
        public string BuildFrom{ get; set; }

        /// <summary>
        /// <p>Template ID</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>Build specification. The current server still reads from edgeone.json. This field is reserved for now.</p>
        /// </summary>
        [JsonProperty("CiSpec")]
        public string CiSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ViaMeta", this.ViaMeta);
            this.SetParamSimple(map, prefix + "Env", this.Env);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "DistType", this.DistType);
            this.SetParamSimple(map, prefix + "TempBucketPath", this.TempBucketPath);
            this.SetParamSimple(map, prefix + "RepoBranch", this.RepoBranch);
            this.SetParamSimple(map, prefix + "RepoCommitHash", this.RepoCommitHash);
            this.SetParamSimple(map, prefix + "RepoCommitMsg", this.RepoCommitMsg);
            this.SetParamSimple(map, prefix + "BuildFrom", this.BuildFrom);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "CiSpec", this.CiSpec);
        }
    }
}

