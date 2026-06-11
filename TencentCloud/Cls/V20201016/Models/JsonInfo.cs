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

    public class JsonInfo : AbstractModel
    {
        
        /// <summary>
        /// Enablement flag
        /// </summary>
        [JsonProperty("EnableTag")]
        public bool? EnableTag{ get; set; }

        /// <summary>
        /// Metadata information list, available values are __SOURCE__, __FILENAME__, __TIMESTAMP__, __HOSTNAME__.
        /// 
        /// -SOURCE IP for log collection, for example: 10.0.1.2
        /// -__FILENAME__: Log collection file name, for example: /data/log/nginx/access.log
        /// -__TIMESTAMP__: Log timestamp (millisecond-level Unix timestamp). When retrieving logs by time range, the time is automatically used to retrieve logs. It is displayed on the console as "log time", for example: 1640005601188.
        /// -__HOSTNAME__: Log source machine name. Need to use Loglistener 2.7.4 and above versions to capture this field, for example: localhost.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MetaFields")]
        public string[] MetaFields{ get; set; }

        /// <summary>
        /// JSON format for shipping. 0: shipped as a string; 1: shipped in a structured way.
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
            this.SetParamSimple(map, prefix + "JsonType", this.JsonType);
        }
    }
}

