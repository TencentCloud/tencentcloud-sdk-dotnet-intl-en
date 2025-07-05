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
        /// Whether to deliver TAG information.
        /// When EnableTag is true, it indicates the delivery of TAG metadata.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// List of metadata to ship. Supported metadata types: \_\_SOURCE\_\_, \_\_FILENAME\_\_, \_\_TIMESTAMP\_\_, \_\_HOSTNAME\_\_, and \_\_PKGID\_\_.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// When EnableTag is true, the TagJsonNotTiled field must be filled.TagJsonNotTiled is used to indicate whether tag information is JSON flattened.When TagJsonNotTiled is true, it is not flattened. Example:TAG information: `{"__TAG__":{"fieldA":200,"fieldB":"text"}}`
        /// Untiled: `{"__TAG__":{"fieldA":200,"fieldB":"text"}}`When TagJsonNotTiled is false, the data is tiled. Example:TAG information: `{"__TAG__":{"fieldA":200,"fieldB":"text"}}`Tiled: `{"__TAG__.fieldA":200,"__TAG__.fieldB":"text"}`
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagJsonNotTiled")]
        public bool? TagJsonNotTiled{ get; set; }

        /// <summary>
        /// Delivery timestamp precision, optional [1: second; 2: millisecond], default is 1.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimestampAccuracy")]
        public long? TimestampAccuracy{ get; set; }

        /// <summary>
        /// Deliver in JSON format.JsonType is 0: Consistent with the original log, no escape. Example:
        /// Original log: `{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`Deliver to CKafka: `{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`JsonType is 1: Escaped. Example:Original log: `{"a":"aa", "b":{"b1":"b1b1", "c1":"c1c1"}}`Delivered to CKafka: `{"a":"aa","b":"{\"b1\":\"b1b1\", \"c1\":\"c1c1\"}"}`
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

