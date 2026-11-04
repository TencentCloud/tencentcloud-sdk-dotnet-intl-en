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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QALifecycle : AbstractModel
    {
        
        /// <summary>
        /// <p>Creation time (Unix seconds).</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>Expiration policy (validity time and behavior after the validity period expires)</p>
        /// </summary>
        [JsonProperty("ExpirationPolicy")]
        public ExpirationPolicy ExpirationPolicy{ get; set; }

        /// <summary>
        /// <p>Status: 1=pending verification, 2=not adopted, 3=import failed, 4=under review, 5=review failed, 6=Learning, 7=learn failed, 8=import completed, 9=expired, 10=quota invalid, 11=quota recovering, 12=manual appeal in progress, 13=manual appeal failed<table><tbody><tr><td>Enumeration item</td><td>Enumeration value</td><td>Description</td></tr><tr><td>QA_STATUS_UNKNOWN</td><td>0</td><td></td></tr><tr><td>QA_STATUS_PENDING_VERIFY</td><td>1</td><td>Pending verification</td></tr><tr><td>QA_STATUS_NOT_ACCEPTED</td><td>2</td><td>Not adopted</td></tr><tr><td>QA_STATUS_IMPORT_FAIL</td><td>3</td><td>Import failed</td></tr><tr><td>QA_STATUS_AUDITING</td><td>4</td><td>Under review</td></tr><tr><td>QA_STATUS_AUDIT_FAIL</td><td>5</td><td>Review failed</td></tr><tr><td>QA_STATUS_LEARNING</td><td>6</td><td>Learning</td></tr><tr><td>QA_STATUS_LEARN_FAIL</td><td>7</td><td>Learn failed</td></tr><tr><td>QA_STATUS_IMPORTED</td><td>8</td><td>Import completed</td></tr><tr><td>QA_STATUS_EXPIRED</td><td>9</td><td>Expired</td></tr><tr><td>QA_STATUS_QUOTA_INVALID</td><td>10</td><td>Quota invalid</td></tr><tr><td>QA_STATUS_QUOTA_RECOVERING</td><td>11</td><td>Quota recovering</td></tr><tr><td>QA_STATUS_MANUAL_APPEALING</td><td>12</td><td>Manual appeal in progress</td></tr><tr><td>QA_STATUS_MANUAL_APPEAL_FAIL</td><td>13</td><td>Manual appeal failed</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>Status description.</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>Status additional information</p>
        /// </summary>
        [JsonProperty("StatusMessage")]
        public string StatusMessage{ get; set; }

        /// <summary>
        /// <p>Update time (Unix seconds).</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "ExpirationPolicy.", this.ExpirationPolicy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "StatusMessage", this.StatusMessage);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

