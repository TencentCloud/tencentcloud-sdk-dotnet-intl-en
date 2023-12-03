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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateCertificateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// One-click update old certificate ID
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }

        /// <summary>
        /// Type of the resource that needs to be deployed. The following parameter values are optional: clb, cdn, waf, live, ddos, teo, apigateway, vod, tke, and tcb.
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }

        /// <summary>
        /// One-click update new certificate ID
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// List of regions that need to be deployed (deprecated)
        /// </summary>
        [JsonProperty("Regions")]
        [System.Obsolete]
        public string[] Regions{ get; set; }

        /// <summary>
        /// List of regions for which cloud resources need to be deployed
        /// </summary>
        [JsonProperty("ResourceTypesRegions")]
        public ResourceTypeRegions[] ResourceTypesRegions{ get; set; }

        /// <summary>
        /// Public key of the certificate. If the public key of the certificate is uploaded, CertificateId does not need to be uploaded.
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// Private key of the certificate. If the public key of the certificate is uploaded, the private key of the certificate is required.
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// Whether an expiration reminder is ignored for the old certificate. 0: The notification is not ignored. 1: The notification is ignored.
        /// </summary>
        [JsonProperty("ExpiringNotificationSwitch")]
        public ulong? ExpiringNotificationSwitch{ get; set; }

        /// <summary>
        /// Whether repeated uploading of the same certificate is allowed. If the public key of the certificate is uploaded, this parameter can be configured.
        /// </summary>
        [JsonProperty("Repeatable")]
        public bool? Repeatable{ get; set; }

        /// <summary>
        /// Whether downloading is allowed. If the public key of the certificate is uploaded, this parameter can be configured.
        /// </summary>
        [JsonProperty("AllowDownload")]
        public bool? AllowDownload{ get; set; }

        /// <summary>
        /// Tag list. If the public key of the certificate is uploaded, this parameter can be configured.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Project ID. If the public key of the certificate is uploaded, this parameter can be configured.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
            this.SetParamArraySimple(map, prefix + "ResourceTypes.", this.ResourceTypes);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamArraySimple(map, prefix + "Regions.", this.Regions);
            this.SetParamArrayObj(map, prefix + "ResourceTypesRegions.", this.ResourceTypesRegions);
            this.SetParamSimple(map, prefix + "CertificatePublicKey", this.CertificatePublicKey);
            this.SetParamSimple(map, prefix + "CertificatePrivateKey", this.CertificatePrivateKey);
            this.SetParamSimple(map, prefix + "ExpiringNotificationSwitch", this.ExpiringNotificationSwitch);
            this.SetParamSimple(map, prefix + "Repeatable", this.Repeatable);
            this.SetParamSimple(map, prefix + "AllowDownload", this.AllowDownload);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

