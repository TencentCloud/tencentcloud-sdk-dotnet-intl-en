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

    public class ModifyInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// tencent cloud MQTT instance ID, obtained from the [DescribeInstanceList](https://www.tencentcloud.com/document/api/1778/111029?from_cn_redirect=1) api or console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the instance name to be modified, cannot be empty, 3-64 characters, only comprised of digits, letters, "-", and "_".
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Specifies the remark information to be modified, with a maximum of 128 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Specifies the configuration specification to be changed.
        /// Basic version and professional edition clusters cannot be upgraded to platinum version specifications. platinum edition clusters cannot be downgraded to basic version and enhanced specifications.
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// Specifies the registration method for the client certificate.
        /// JITP: automatically register.
        /// API: register manually through api.
        /// </summary>
        [JsonProperty("DeviceCertificateProvisionType")]
        [System.Obsolete]
        public string DeviceCertificateProvisionType{ get; set; }

        /// <summary>
        /// Specifies whether to automatically activate the cert after automatic registration.
        /// </summary>
        [JsonProperty("AutomaticActivation")]
        [System.Obsolete]
        public bool? AutomaticActivation{ get; set; }

        /// <summary>
        /// Authorization policy switch.
        /// </summary>
        [JsonProperty("AuthorizationPolicy")]
        public bool? AuthorizationPolicy{ get; set; }

        /// <summary>
        /// Specifies whether to use the default server certificate.
        /// </summary>
        [JsonProperty("UseDefaultServerCert")]
        public bool? UseDefaultServerCert{ get; set; }

        /// <summary>
        /// TLS: one-way authentication.
        /// mTLS. specifies mutual authentication.
        /// BYOC: one device, one certificate.
        /// </summary>
        [JsonProperty("X509Mode")]
        public string X509Mode{ get; set; }

        /// <summary>
        /// Specifies the speed limit unit for client message send and receive in messages per second.
        /// </summary>
        [JsonProperty("MessageRate")]
        public long? MessageRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "DeviceCertificateProvisionType", this.DeviceCertificateProvisionType);
            this.SetParamSimple(map, prefix + "AutomaticActivation", this.AutomaticActivation);
            this.SetParamSimple(map, prefix + "AuthorizationPolicy", this.AuthorizationPolicy);
            this.SetParamSimple(map, prefix + "UseDefaultServerCert", this.UseDefaultServerCert);
            this.SetParamSimple(map, prefix + "X509Mode", this.X509Mode);
            this.SetParamSimple(map, prefix + "MessageRate", this.MessageRate);
        }
    }
}

