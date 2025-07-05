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
        /// The COS URL of the script, in the format of `https://beijing-111111.cos.ap-beijing.myqcloud.com/data/test.sh`. For the COS bucket list, see [Bucket List](https://console.cloud.tencent.com/cos/bucket).
        /// </summary>
        [JsonProperty("CosFileURI")]
        public string CosFileURI{ get; set; }

        /// <summary>
        /// The execution time of the bootstrap action script. Valid values:
        /// <li>`resourceAfter`: After node initialization</li>
        /// <li>`clusterAfter`: After cluster start</li>
        /// <li>`clusterBefore`: Before cluster start</li>
        /// </summary>
        [JsonProperty("ExecutionMoment")]
        public string ExecutionMoment{ get; set; }

        /// <summary>
        /// The execution script parameter. The parameter format must comply with standard shell specifications.
        /// </summary>
        [JsonProperty("Args")]
        public string[] Args{ get; set; }

        /// <summary>
        /// The script file name.
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosFileURI", this.CosFileURI);
            this.SetParamSimple(map, prefix + "ExecutionMoment", this.ExecutionMoment);
            this.SetParamArraySimple(map, prefix + "Args.", this.Args);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
        }
    }
}

