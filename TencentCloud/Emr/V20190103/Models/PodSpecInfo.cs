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

    public class PodSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// The specified information such as pod spec and source for scale-out with pod resources.
        /// </summary>
        [JsonProperty("PodSpec")]
        public PodNewSpec PodSpec{ get; set; }

        /// <summary>
        /// The custom pod permission and parameter.
        /// </summary>
        [JsonProperty("PodParameter")]
        public PodNewParameter PodParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "PodSpec.", this.PodSpec);
            this.SetParamObj(map, prefix + "PodParameter.", this.PodParameter);
        }
    }
}

