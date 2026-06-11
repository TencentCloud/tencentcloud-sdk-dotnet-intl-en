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

    public class UploadLogRequest : AbstractModel, IOctetRequest
    {
        
        /// <summary>
        /// Log topic id
        /// -Obtain the log topic Id through [Get Log Topic List](https://www.tencentcloud.com/document/product/614/56454?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// This parameter has been deprecated and should not be used.
        /// </summary>
        [JsonProperty("HashKey")]
        [System.Obsolete]
        public string HashKey{ get; set; }

        /// <summary>
        /// Compression method. Currently supports
        /// - lz4
        /// - zstd
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }

        public byte[] OctetBody { get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "HashKey", this.HashKey);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

