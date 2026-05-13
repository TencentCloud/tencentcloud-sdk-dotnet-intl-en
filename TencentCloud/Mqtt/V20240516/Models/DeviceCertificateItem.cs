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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceCertificateItem : AbstractModel
    {
        
        /// <summary>
        /// Client ID.
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// device certificate
        /// </summary>
        [JsonProperty("DeviceCertificate")]
        public string DeviceCertificate{ get; set; }

        /// <summary>
        /// Device certificate SN serial number, used for unique identification of a device certificate
        /// </summary>
        [JsonProperty("DeviceCertificateSn")]
        public string DeviceCertificateSn{ get; set; }

        /// <summary>
        /// Device certificate Cn
        /// </summary>
        [JsonProperty("DeviceCertificateCn")]
        public string DeviceCertificateCn{ get; set; }

        /// <summary>
        /// Serial number of the CA cert that issued the cert
        /// </summary>
        [JsonProperty("CaSn")]
        public string CaSn{ get; set; }

        /// <summary>
        /// Certificate format, currently only support PEM
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// Device certificate status
        /// ACTIVE: Activate
        /// INACTIVE: Inactive
        /// REVOKED: Revoked
        /// PENDING_ACTIVATION: To be activated.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Organization unit
        /// </summary>
        [JsonProperty("OrganizationalUnit")]
        public string OrganizationalUnit{ get; set; }

        /// <summary>
        /// Last activation time, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("LastActivationTime")]
        public long? LastActivationTime{ get; set; }

        /// <summary>
        /// Last cancellation activation time, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("LastInactivationTime")]
        public long? LastInactivationTime{ get; set; }

        /// <summary>
        /// createTime, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// Update time, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// Certificate source:
        /// API, Manual Registration   
        /// Automatic JITP registration
        /// </summary>
        [JsonProperty("CertificateSource")]
        public string CertificateSource{ get; set; }

        /// <summary>
        /// Certificate expiration date, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("NotAfterTime")]
        public long? NotAfterTime{ get; set; }

        /// <summary>
        /// Start date when the certificate takes effect, millisecond-level timestamp.
        /// </summary>
        [JsonProperty("NotBeforeTime")]
        public long? NotBeforeTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "DeviceCertificate", this.DeviceCertificate);
            this.SetParamSimple(map, prefix + "DeviceCertificateSn", this.DeviceCertificateSn);
            this.SetParamSimple(map, prefix + "DeviceCertificateCn", this.DeviceCertificateCn);
            this.SetParamSimple(map, prefix + "CaSn", this.CaSn);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OrganizationalUnit", this.OrganizationalUnit);
            this.SetParamSimple(map, prefix + "LastActivationTime", this.LastActivationTime);
            this.SetParamSimple(map, prefix + "LastInactivationTime", this.LastInactivationTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CertificateSource", this.CertificateSource);
            this.SetParamSimple(map, prefix + "NotAfterTime", this.NotAfterTime);
            this.SetParamSimple(map, prefix + "NotBeforeTime", this.NotBeforeTime);
        }
    }
}

