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
        /// The old certificate id for one-click update. by querying the cloud resources bound to this certificate id, and then updating these cloud resources with the new certificate.
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }

        /// <summary>
        /// Resource types that need to be deployed, with optional parameter values (lowercase): clb, cdn, waf, live, ddos, teo, apigateway, vod, tke, tcb, tse, cos.
        /// </summary>
        [JsonProperty("ResourceTypes")]
        public string[] ResourceTypes{ get; set; }

        /// <summary>
        /// New certificate id for one-click update. if this parameter is not provided, the public key certificate and private key certificate must be provided.
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
        /// List of regions where cloud resources need to be deployed. the cloud resource type of the supported region must be passed. valid values: clb, tke, apigateway, waf, tcb, tse, cos.
        /// </summary>
        [JsonProperty("ResourceTypesRegions")]
        public ResourceTypeRegions[] ResourceTypesRegions{ get; set; }

        /// <summary>
        /// If a public key certificate is uploaded, the private key certificate must also be uploaded, and the CertificateId does not need to be transmitted.
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// If a private key certificate is uploaded, then a public key certificate must be uploaded; CertificateId is not required.
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// Whether to ignore expiration reminder for old certificate  0: do not ignore the notification. 1: ignore the notification, ignore the expiration reminder of OldCertificateId.
        /// </summary>
        [JsonProperty("ExpiringNotificationSwitch")]
        public ulong? ExpiringNotificationSwitch{ get; set; }

        /// <summary>
        /// It specifies whether the same certificate is allowed to be uploaded repeatedly. If the public key and private key certificates are selected for upload, this parameter can be configured. If there are duplicate certificates, the update task will fail.
        /// </summary>
        [JsonProperty("Repeatable")]
        public bool? Repeatable{ get; set; }

        /// <summary>
        /// Whether to allow downloading. If you choose to upload a public/private key certificate, this parameter can be configured.
        /// </summary>
        [JsonProperty("AllowDownload")]
        public bool? AllowDownload{ get; set; }

        /// <summary>
        /// Tag list. If you choose to upload a public/private key certificate, you can configure this parameter.
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Project id. If you choose to upload a public/private key certificate, you can configure this parameter.
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

