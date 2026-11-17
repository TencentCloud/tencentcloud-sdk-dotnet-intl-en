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

    public class KafkaConsumerContent : AbstractModel
    {
        
        /// <summary>
        /// <p>Consumption data format. 0: Raw content; 1: JSON.</p>
        /// </summary>
        [JsonProperty("Format")]
        public long? Format{ get; set; }

        /// <summary>
        /// <p>Whether to deliver TAG information<br>When Format is 0, this field does not need to be assigned a value</p>
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// <p>Metadata information list. Valid values: __SOURCE__, __FILENAME__<br>, __TIMESTAMP__, __HOSTNAME__, __PKGID__<br>When Format is 0, this field does not need to be assigned a value</p>
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// <p>Tag data processing method. 1: Not flattened (default); 2: Flattened.</p><p>Not flattened example:<br>TAG information: <code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code><br>Not flattened: <code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code></p><p>Flattened example:<br>TAG information: <code>{&quot;__TAG__&quot;:{&quot;fieldA&quot;:200,&quot;fieldB&quot;:&quot;text&quot;}}</code><br>Flattened: <code>{&quot;__TAG__.fieldA&quot;:200,&quot;__TAG__.fieldB&quot;:&quot;text&quot;}</code></p>
        /// </summary>
        [JsonProperty("TagTransaction")]
        public long? TagTransaction{ get; set; }

        /// <summary>
        /// <p>Consumption data Json format:<br>1: Not escaped (default format)<br>2: Escaped</p><p>Delivery Json format.<br>When JsonType is 1: Consistent with the original log, not escaped. Example:<br>Original log: <code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>Delivered to Ckafka: <code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code></p><p>When JsonType is 2: Escaped. Example:<br>Original log: <code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>Delivered to Ckafka: <code>{&quot;a&quot;:&quot;aa&quot;,&quot;b&quot;:&quot;{\&quot;b1\&quot;:\&quot;b1b1\&quot;, \&quot;c1\&quot;:\&quot;c1c1\&quot;}&quot;}</code></p>
        /// </summary>
        [JsonProperty("JsonType")]
        public long? JsonType{ get; set; }

        /// <summary>
        /// <p>Switch for automatic conversion of numeric types</p><p>Valid values:</p><ul><li>true: Numeric strings (such as &quot;123&quot;) in the first-level values of the JSON structure are automatically converted to numeric types (int/float).</li><li>false: Numeric strings (such as &quot;123&quot;) in the first-level values of the JSON structure remain strings.</li></ul><p>Default value: false</p>
        /// </summary>
        [JsonProperty("AutoConvertNumber")]
        public bool? AutoConvertNumber{ get; set; }


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
            this.SetParamSimple(map, prefix + "AutoConvertNumber", this.AutoConvertNumber);
        }
    }
}

