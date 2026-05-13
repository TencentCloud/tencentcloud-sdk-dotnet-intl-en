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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplyDiskBackupRequest : AbstractModel
    {
        
        /// <summary>
        /// Cloud disk backup point ID. can be queried through the [DescribeDiskBackups](https://www.tencentcloud.com/document/product/362/80278?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("DiskBackupId")]
        public string DiskBackupId{ get; set; }

        /// <summary>
        /// Original cloud disk ID of the backup point. can be queried through the [DescribeDisks](https://www.tencentcloud.com/document/product/362/16315?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Specifies whether to enable automatic shutdown before rolling back the CBS backup point. defaults to FALSE, which means no automatic shutdown.
        /// </summary>
        [JsonProperty("AutoStopInstance")]
        public bool? AutoStopInstance{ get; set; }

        /// <summary>
        /// Whether to automatically start after rolling back the cloud disk backup point, default to FALSE, means do not auto boot. the AutoStartInstance parameter can only be set to true when AutoStopInstance is true.
        /// </summary>
        [JsonProperty("AutoStartInstance")]
        public bool? AutoStartInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskBackupId", this.DiskBackupId);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "AutoStopInstance", this.AutoStopInstance);
            this.SetParamSimple(map, prefix + "AutoStartInstance", this.AutoStartInstance);
        }
    }
}

