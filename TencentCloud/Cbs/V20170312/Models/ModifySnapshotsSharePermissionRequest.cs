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

    public class ModifySnapshotsSharePermissionRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the snapshot. You can obtain this by using [DescribeSnapshots](https://intl.cloud.tencent.com/document/api/362/15647?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string[] SnapshotIds{ get; set; }

        /// <summary>
        /// Account Id list for receiving shared snapshots. the format of array-type parameters can be found in the API overview (https://www.tencentcloud.com/document/API/213/568?from_cn_redirect=1). the account Id is different from a QQ number. to query a user account Id, view the account Id column in the account information (https://console.cloud.tencent.com/developer).
        /// </summary>
        [JsonProperty("AccountIds")]
        public string[] AccountIds{ get; set; }

        /// <summary>
        /// Operations. Valid values: `SHARE`, sharing an image; `CANCEL`, cancelling the sharing of an image.
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
            this.SetParamArraySimple(map, prefix + "AccountIds.", this.AccountIds);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
        }
    }
}

