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

    public class ConsumerContent : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to deliver TAG information.<br>When EnableTag is true, it means to deliver TAG metadata.</p>
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// <p>List of metadata to be shipped, currently only support: __SOURCE__, __FILENAME__, __TIMESTAMP__, __HOSTNAME__, and __PKGID__</p>
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// <p>When EnableTag is true, the TagJsonNotTiled field must be filled.<br>TagJsonNotTiled indicates whether tag information is json tiled.</p><p>When TagJsonNotTiled is true, it is not tiled. Example:<br>tag information: <code>{"__tag__":{"fieldA":200,"fieldB":"text"}}</code><br>Not Tiled: <code>{"__tag__":{"fieldA":200,"fieldB":"text"}}</code></p><p>When TagJsonNotTiled is false, tiling is applied. Example:<br>tag information: <code>{"__tag__":{"fieldA":200,"fieldB":"text"}}</code><br>Tiled: <code>{"__tag__.fieldA":200,"__tag__.fieldB":"text"}</code></p>
        /// </summary>
        [JsonProperty("TagJsonNotTiled")]
        public bool? TagJsonNotTiled{ get; set; }

        /// <summary>
        /// <p>Delivery timestamp precision, options [1: second; 2: millisecond], 1 is selected by default.</p>
        /// </summary>
        [JsonProperty("TimestampAccuracy")]
        public long? TimestampAccuracy{ get; set; }

        /// <summary>
        /// <p>Deliver in Json format.</p><p>Enumeration value:</p><ul><li>0: Escape. Example:<br>Original log: <code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>Deliver to Ckafka: <code>{&quot;a&quot;:&quot;aa&quot;,&quot;b&quot;:&quot;{\&quot;b1\&quot;:\&quot;b1b1\&quot;, \&quot;c1\&quot;:\&quot;c1c1\&quot;}&quot;}</code></li><li>1: Consistent with original log, non-escaping. Example:<br>Original log: <code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code><br>Deliver to Ckafka: <code>{&quot;a&quot;:&quot;aa&quot;, &quot;b&quot;:{&quot;b1&quot;:&quot;b1b1&quot;, &quot;c1&quot;:&quot;c1c1&quot;}}</code></li></ul>
        /// </summary>
        [JsonProperty("JsonType")]
        public long? JsonType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableTag", this.EnableTag);
            this.SetParamArraySimple(map, prefix + "MetaFields.", this.MetaFields);
            this.SetParamSimple(map, prefix + "TagJsonNotTiled", this.TagJsonNotTiled);
            this.SetParamSimple(map, prefix + "TimestampAccuracy", this.TimestampAccuracy);
            this.SetParamSimple(map, prefix + "JsonType", this.JsonType);
        }
    }
}

