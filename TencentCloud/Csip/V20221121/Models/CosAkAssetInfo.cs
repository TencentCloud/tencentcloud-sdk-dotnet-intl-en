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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CosAkAssetInfo : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// ak id
        /// </summary>
        [JsonProperty("AkId")]
        public string AkId{ get; set; }

        /// <summary>
        /// ak name
        /// </summary>
        [JsonProperty("AkName")]
        public string AkName{ get; set; }

        /// <summary>
        /// ak remark
        /// </summary>
        [JsonProperty("AkRemark")]
        public string AkRemark{ get; set; }

        /// <summary>
        /// uin associated with the ak
        /// </summary>
        [JsonProperty("AkOwnerUin")]
        public string AkOwnerUin{ get; set; }

        /// <summary>
        /// ak type. 1: primary. 2: sub
        /// </summary>
        [JsonProperty("AkOwnerType")]
        public long? AkOwnerType{ get; set; }

        /// <summary>
        /// ak account name
        /// </summary>
        [JsonProperty("AkOwnerName")]
        public string AkOwnerName{ get; set; }

        /// <summary>
        /// ak main account name
        /// </summary>
        [JsonProperty("AkMainOwnerName")]
        public string AkMainOwnerName{ get; set; }

        /// <summary>
        /// ak-associated bucket collection
        /// </summary>
        [JsonProperty("AkRelBucketSet")]
        public string[] AkRelBucketSet{ get; set; }

        /// <summary>
        /// ak associated alarm collection
        /// </summary>
        [JsonProperty("AkRelAlarmSet")]
        public CosRiskInfo[] AkRelAlarmSet{ get; set; }

        /// <summary>
        /// Number of IPs associated with Ak
        /// </summary>
        [JsonProperty("AkRelIpCount")]
        public ulong? AkRelIpCount{ get; set; }

        /// <summary>
        /// ak status. 0: disabled. 1: enabled.
        /// </summary>
        [JsonProperty("AkStatus")]
        public long? AkStatus{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTimestamp")]
        public ulong? CreateTimestamp{ get; set; }

        /// <summary>
        /// Last access time
        /// </summary>
        [JsonProperty("LastAccessTimestamp")]
        public ulong? LastAccessTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AkId", this.AkId);
            this.SetParamSimple(map, prefix + "AkName", this.AkName);
            this.SetParamSimple(map, prefix + "AkRemark", this.AkRemark);
            this.SetParamSimple(map, prefix + "AkOwnerUin", this.AkOwnerUin);
            this.SetParamSimple(map, prefix + "AkOwnerType", this.AkOwnerType);
            this.SetParamSimple(map, prefix + "AkOwnerName", this.AkOwnerName);
            this.SetParamSimple(map, prefix + "AkMainOwnerName", this.AkMainOwnerName);
            this.SetParamArraySimple(map, prefix + "AkRelBucketSet.", this.AkRelBucketSet);
            this.SetParamArrayObj(map, prefix + "AkRelAlarmSet.", this.AkRelAlarmSet);
            this.SetParamSimple(map, prefix + "AkRelIpCount", this.AkRelIpCount);
            this.SetParamSimple(map, prefix + "AkStatus", this.AkStatus);
            this.SetParamSimple(map, prefix + "CreateTimestamp", this.CreateTimestamp);
            this.SetParamSimple(map, prefix + "LastAccessTimestamp", this.LastAccessTimestamp);
        }
    }
}

