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

namespace TencentCloud.Eb.V20210416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ESTargetParams : AbstractModel
    {
        
        /// <summary>
        /// Network connection type
        /// </summary>
        [JsonProperty("NetMode")]
        public string NetMode{ get; set; }

        /// <summary>
        /// Index prefix
        /// </summary>
        [JsonProperty("IndexPrefix")]
        public string IndexPrefix{ get; set; }

        /// <summary>
        /// ES log rotation interval
        /// </summary>
        [JsonProperty("RotationInterval")]
        public string RotationInterval{ get; set; }

        /// <summary>
        /// DTS event configuration
        /// </summary>
        [JsonProperty("OutputMode")]
        public string OutputMode{ get; set; }

        /// <summary>
        /// DTS indexing configuration
        /// </summary>
        [JsonProperty("IndexSuffixMode")]
        public string IndexSuffixMode{ get; set; }

        /// <summary>
        /// ES template type
        /// </summary>
        [JsonProperty("IndexTemplateType")]
        public string IndexTemplateType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetMode", this.NetMode);
            this.SetParamSimple(map, prefix + "IndexPrefix", this.IndexPrefix);
            this.SetParamSimple(map, prefix + "RotationInterval", this.RotationInterval);
            this.SetParamSimple(map, prefix + "OutputMode", this.OutputMode);
            this.SetParamSimple(map, prefix + "IndexSuffixMode", this.IndexSuffixMode);
            this.SetParamSimple(map, prefix + "IndexTemplateType", this.IndexTemplateType);
        }
    }
}

