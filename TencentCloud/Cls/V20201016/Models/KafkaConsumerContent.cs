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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KafkaConsumerContent : AbstractModel
    {
        
        /// <summary>
        /// Format. Valid values: 0 (full-text) and 1 (JSON).
        /// </summary>
        [JsonProperty("Format")]
        public long? Format{ get; set; }

        /// <summary>
        /// Whether to ship tag information
        /// This parameter does not need to be set when `Format` is set to `0`.
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// Metadata information list. Valid values: \_\_SOURCE\_\_, \_\_FILENAME\_\_,
        /// \_\_TIMESTAMP\_\_, \_\_HOSTNAME\_\_, and \_\_PKGID\_\_.
        /// This parameter does not need to be set when `Format` is set to `0`.
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// Tag data processing mode. Valid values:
        /// 1 (default): Do not tile data.
        /// 2: Tile data.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagTransaction")]
        public long? TagTransaction{ get; set; }

        /// <summary>
        /// JSON data format. Valid values:
        /// 1 (default): Not escaped.
        /// 2: Escaped.
        /// </summary>
        [JsonProperty("JsonType")]
        public long? JsonType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "TagTransaction", this.TagTransaction);
            this.SetParamSimple(map, prefix + "JsonType", this.JsonType);
        }
    }
}

