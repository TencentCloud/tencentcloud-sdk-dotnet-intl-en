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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmsPackagesStatistics : AbstractModel
    {
        
        /// <summary>
        /// Package creation time in standard time format, such as 2019-10-08 17:18:37.
        /// </summary>
        [JsonProperty("PackageCreateTime")]
        public string PackageCreateTime{ get; set; }

        /// <summary>
        /// Package creation time in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("PackageCreateUnixTime")]
        public ulong? PackageCreateUnixTime{ get; set; }

        /// <summary>
        /// Package effective time in standard time format, such as 2019-10-08 17:18:37.
        /// </summary>
        [JsonProperty("PackageEffectiveTime")]
        public string PackageEffectiveTime{ get; set; }

        /// <summary>
        /// Package effective time in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("PackageEffectiveUnixTime")]
        public ulong? PackageEffectiveUnixTime{ get; set; }

        /// <summary>
        /// Package expiration time in standard time format, such as 2019-10-08 17:18:37.
        /// </summary>
        [JsonProperty("PackageExpiredTime")]
        public string PackageExpiredTime{ get; set; }

        /// <summary>
        /// Package expiration time in seconds in the format of UNIX timestamp.
        /// </summary>
        [JsonProperty("PackageExpiredUnixTime")]
        public ulong? PackageExpiredUnixTime{ get; set; }

        /// <summary>
        /// Number of SMS messages in package.
        /// </summary>
        [JsonProperty("AmountOfPackage")]
        public ulong? AmountOfPackage{ get; set; }

        /// <summary>
        /// 0: gifted package. 1: purchased package.
        /// </summary>
        [JsonProperty("TypeOfPackage")]
        public ulong? TypeOfPackage{ get; set; }

        /// <summary>
        /// Package ID.
        /// </summary>
        [JsonProperty("PackageId")]
        public ulong? PackageId{ get; set; }

        /// <summary>
        /// Current usage.
        /// </summary>
        [JsonProperty("CurrentUsage")]
        public ulong? CurrentUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageCreateTime", this.PackageCreateTime);
            this.SetParamSimple(map, prefix + "PackageCreateUnixTime", this.PackageCreateUnixTime);
            this.SetParamSimple(map, prefix + "PackageEffectiveTime", this.PackageEffectiveTime);
            this.SetParamSimple(map, prefix + "PackageEffectiveUnixTime", this.PackageEffectiveUnixTime);
            this.SetParamSimple(map, prefix + "PackageExpiredTime", this.PackageExpiredTime);
            this.SetParamSimple(map, prefix + "PackageExpiredUnixTime", this.PackageExpiredUnixTime);
            this.SetParamSimple(map, prefix + "AmountOfPackage", this.AmountOfPackage);
            this.SetParamSimple(map, prefix + "TypeOfPackage", this.TypeOfPackage);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "CurrentUsage", this.CurrentUsage);
        }
    }
}

