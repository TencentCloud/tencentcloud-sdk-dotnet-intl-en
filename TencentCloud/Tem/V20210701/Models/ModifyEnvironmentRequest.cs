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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEnvironmentRequest : AbstractModel
    {
        
        /// <summary>
        /// Environment ID
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Environment name
        /// </summary>
        [JsonProperty("EnvironmentName")]
        public string EnvironmentName{ get; set; }

        /// <summary>
        /// Environment description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// VPC name
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// Subnets
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// Source channel
        /// </summary>
        [JsonProperty("SourceChannel")]
        public long? SourceChannel{ get; set; }

        /// <summary>
        /// Environment type. Values: `test`, `pre`, `prod`
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "EnvironmentName", this.EnvironmentName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "SourceChannel", this.SourceChannel);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
        }
    }
}

