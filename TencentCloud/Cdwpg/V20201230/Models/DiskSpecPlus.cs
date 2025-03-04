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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskSpecPlus : AbstractModel
    {
        
        /// <summary>
        /// Disk Count
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskCount")]
        public long? DiskCount{ get; set; }

        /// <summary>
        /// Max Disk Size
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxDiskSize")]
        public long? MaxDiskSize{ get; set; }

        /// <summary>
        /// Min Disk Size
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinDiskSize")]
        public long? MinDiskSize{ get; set; }

        /// <summary>
        /// Disk Type
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Disk Description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DiskDesc")]
        public string DiskDesc{ get; set; }

        /// <summary>
        /// Cvm Class
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CvmClass")]
        public string CvmClass{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "MaxDiskSize", this.MaxDiskSize);
            this.SetParamSimple(map, prefix + "MinDiskSize", this.MinDiskSize);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskDesc", this.DiskDesc);
            this.SetParamSimple(map, prefix + "CvmClass", this.CvmClass);
        }
    }
}

