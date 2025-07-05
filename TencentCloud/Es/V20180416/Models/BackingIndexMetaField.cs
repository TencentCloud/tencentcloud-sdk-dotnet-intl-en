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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackingIndexMetaField : AbstractModel
    {
        
        /// <summary>
        /// Backing index name
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IndexName")]
        public string IndexName{ get; set; }

        /// <summary>
        /// Backing index status
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IndexStatus")]
        public string IndexStatus{ get; set; }

        /// <summary>
        /// Backing index size
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IndexStorage")]
        public long? IndexStorage{ get; set; }

        /// <summary>
        /// Current lifecycle phase of backing index
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IndexPhrase")]
        public string IndexPhrase{ get; set; }

        /// <summary>
        /// Backing index creation time
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IndexCreateTime")]
        public string IndexCreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IndexName", this.IndexName);
            this.SetParamSimple(map, prefix + "IndexStatus", this.IndexStatus);
            this.SetParamSimple(map, prefix + "IndexStorage", this.IndexStorage);
            this.SetParamSimple(map, prefix + "IndexPhrase", this.IndexPhrase);
            this.SetParamSimple(map, prefix + "IndexCreateTime", this.IndexCreateTime);
        }
    }
}

