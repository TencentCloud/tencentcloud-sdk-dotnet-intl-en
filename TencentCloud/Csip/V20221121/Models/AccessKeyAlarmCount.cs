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

    public class AccessKeyAlarmCount : AbstractModel
    {
        
        /// <summary>
        /// Access key ID.
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Access key.
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// Alarm count.
        /// </summary>
        [JsonProperty("AlarmCount")]
        public long? AlarmCount{ get; set; }

        /// <summary>
        /// Security credentials status. valid values: 0 (disabled), 1 (enabled), 2 (deleted).
        /// </summary>
        [JsonProperty("AccessKeyStatus")]
        public long? AccessKeyStatus{ get; set; }

        /// <summary>
        /// AK creation time.
        /// </summary>
        [JsonProperty("AccessKeyCreateTime")]
        public string AccessKeyCreateTime{ get; set; }

        /// <summary>
        /// AK last usage time. returns "-" if never used.
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "AlarmCount", this.AlarmCount);
            this.SetParamSimple(map, prefix + "AccessKeyStatus", this.AccessKeyStatus);
            this.SetParamSimple(map, prefix + "AccessKeyCreateTime", this.AccessKeyCreateTime);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
        }
    }
}

