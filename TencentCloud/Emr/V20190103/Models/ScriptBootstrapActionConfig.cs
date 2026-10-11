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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScriptBootstrapActionConfig : AbstractModel
    {
        
        /// <summary>
        /// COS address of the script. Format: https://beijing-111111.cos.ap-beijing.myqcloud.com/data/test.sh. To query the COS bucket list, refer to [Bucket List](https://console.cloud.tencent.com/cos/bucket).
        /// </summary>
        [JsonProperty("CosFileURI")]
        public string CosFileURI{ get; set; }

        /// <summary>
        /// Time range for the bootstrap script execution.
        /// <li>resourceAfter: after node initialization</li>
        /// <li>clusterAfter: after cluster startup</li>
        /// <li>clusterBefore: before cluster startup</li>
        /// </summary>
        [JsonProperty("ExecutionMoment")]
        public string ExecutionMoment{ get; set; }

        /// <summary>
        /// Execution script parameters. For the parameter format, follow standard Shell specifications.
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// Script file name.
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosFileURI", this.CosFileURI);
            this.SetParamSimple(map, prefix + "ExecutionMoment", this.ExecutionMoment);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

