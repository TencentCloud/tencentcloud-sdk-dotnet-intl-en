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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// Processing statement entered by the user
        /// </summary>
        [JsonProperty("EtlContent")]
        public string EtlContent{ get; set; }

        /// <summary>
        /// Target topic ID and alias of the data processing task
        /// </summary>
        [JsonProperty("DstResources")]
        public DataTransformResouceInfo[] DstResources{ get; set; }

        /// <summary>
        /// Type of the target topic for data processing. Valid values: 1 (fixed Topic) and 2 (dynamic creation)
        /// </summary>
        [JsonProperty("FuncType")]
        public long? FuncType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EtlContent", this.EtlContent);
            this.SetParamArrayObj(map, prefix + "DstResources.", this.DstResources);
            this.SetParamSimple(map, prefix + "FuncType", this.FuncType);
        }
    }
}

