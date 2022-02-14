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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollingUpdateApplicationByVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Environment ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Update version. For image-based deployment, it is the value. For deployment with JAR/WAR files, it is `Version`.
        /// </summary>
        [JsonProperty("DeployVersion")]
        public string DeployVersion{ get; set; }

        /// <summary>
        /// JAR/WAR package name. It’s only required for deployment with JAR/WAR files.
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// Request source. Options: `IntelliJ`, `Coding`
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("DeployStrategyType")]
        public string DeployStrategyType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TotalBatchCount")]
        public long? TotalBatchCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BatchInterval")]
        public long? BatchInterval{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BetaBatchNum")]
        public long? BetaBatchNum{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MinAvailable")]
        public long? MinAvailable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "DeployVersion", this.DeployVersion);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "DeployStrategyType", this.DeployStrategyType);
            this.SetParamSimple(map, prefix + "TotalBatchCount", this.TotalBatchCount);
            this.SetParamSimple(map, prefix + "BatchInterval", this.BatchInterval);
            this.SetParamSimple(map, prefix + "BetaBatchNum", this.BetaBatchNum);
            this.SetParamSimple(map, prefix + "MinAvailable", this.MinAvailable);
        }
    }
}

