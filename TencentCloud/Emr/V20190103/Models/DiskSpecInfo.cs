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

    public class DiskSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// The number of disks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// The system disk type. Valid values:
        /// <li>`CLOUD_SSD`: Cloud SSD</li>
        /// <li>`CLOUD_PREMIUM`: Premium cloud disk</li>
        /// <li>`CLOUD_BASIC`: Cloud HDD</li>
        /// <li>`LOCAL_BASIC`: Local disk</li>
        /// <li>`LOCAL_SSD`: Local SSD</li>
        /// 
        /// The data disk type. Valid values:
        /// <li>`CLOUD_SSD`: Cloud SSD</li>
        /// <li>`CLOUD_PREMIUM`: Premium cloud disk</li>
        /// <li>`CLOUD_BASIC`: Cloud HDD</li>
        /// <li>`LOCAL_BASIC`: Local disk</li>
        /// <li>`LOCAL_SSD`: Local SSD</li>
        /// <li>`CLOUD_HSSD`: Enhanced SSD</li>
        /// <li>`CLOUD_THROUGHPUT`: Throughput HDD</li>
        /// <li>CLOUD_TSSD: ulTra SSD</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// The disk capacity in GB.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
        }
    }
}

