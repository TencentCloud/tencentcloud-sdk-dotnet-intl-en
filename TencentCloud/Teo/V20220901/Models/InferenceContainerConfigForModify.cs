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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceContainerConfigForModify : AbstractModel
    {
        
        /// <summary>
        /// Image type. Valid values: <li>TCR: a Tencent Cloud container mirroring service mirror.</li>
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// TCR image repository information. Required when ImageType is TCR.
        /// </summary>
        [JsonProperty("TcrRepositoryConfig")]
        public InferenceTCRRepositoryConfig TcrRepositoryConfig{ get; set; }

        /// <summary>
        /// Command executed at container startup. Uses the mirror's Entrypoint/CMD by default when left empty. Supports up to 1024 characters.
        /// </summary>
        [JsonProperty("StartupCommand")]
        public string StartupCommand{ get; set; }

        /// <summary>
        /// Environment variables of the container runtime. Supports up to 10 variables.
        /// </summary>
        [JsonProperty("EnvironmentVariables")]
        public InferenceEnvironmentVariable[] EnvironmentVariables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamObj(map, prefix + "TcrRepositoryConfig.", this.TcrRepositoryConfig);
            this.SetParamSimple(map, prefix + "StartupCommand", this.StartupCommand);
            this.SetParamArrayObj(map, prefix + "EnvironmentVariables.", this.EnvironmentVariables);
        }
    }
}

