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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaunchConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>Project ID of the instance.</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>Launch configuration ID.</p>
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// <p>Startup configuration name.</p>
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// <p>Instance model.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Instance system disk configuration information.</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// <p>Instance data disk configuration information.</p>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// <p>Instance login settings.</p>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LimitedLoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// <p>Public network bandwidth-related information settings.</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>Security group to which an instance belongs.</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>The scaling group bound to the launch configuration.</p>
        /// </summary>
        [JsonProperty("AutoScalingGroupAbstractSet")]
        public AutoScalingGroupAbstract[] AutoScalingGroupAbstractSet{ get; set; }

        /// <summary>
        /// <p>Custom data.</p>
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// <p>Launch configuration creation time, in standard <code>UTC</code> time.</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>Enhanced services enabling situation of the instance and its settings.</p>
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// <p>Image ID.</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>Current status of the launch configuration. Value range: <li>NORMAL: Normal</li><li>IMAGE_ABNORMAL: The launch configuration image is exceptional</li><li>CBS_SNAP_ABNORMAL: The launch configuration data disk snapshot is exceptional</li><li>SECURITY_GROUP_ABNORMAL: The launch configuration security group is exceptional</li></p>
        /// </summary>
        [JsonProperty("LaunchConfigurationStatus")]
        public string LaunchConfigurationStatus{ get; set; }

        /// <summary>
        /// <p>Instance billing type. The value range is as follows:</p><li>POSTPAID_BY_HOUR: hourly postpaid</li><li>SPOTPAID: spot payment</li><li>PREPAID: prepaid, i.e. monthly subscription</li><li>CDCPAID: dedicated cluster payment</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Market-related options of the instance, such as spot instance parameters. If the payment mode of the specified instance is spot payment, this parameter is required.</p>
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// <p>Instance model list.</p>
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// <p>Instance tag list. Instances scaled out will automatically come with tags, supporting up to 10 tags.</p>
        /// </summary>
        [JsonProperty("InstanceTags")]
        public InstanceTag[] InstanceTags{ get; set; }

        /// <summary>
        /// <p>Tag list. The tags in this parameter are only used to bind launch configurations and will not be passed to CVM instances scaled out based on the launch configuration.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Version number.</p>
        /// </summary>
        [JsonProperty("VersionNumber")]
        public long? VersionNumber{ get; set; }

        /// <summary>
        /// <p>Update time in standard <code>UTC</code> format.</p>
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// <p>CAM role name, which can be obtained from the roleName in the return value from the <a href="https://www.tencentcloud.com/document/product/598/36223?from_cn_redirect=1">DescribeRoleList</a> API.</p>
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }

        /// <summary>
        /// <p>The value of InstanceTypesCheckPolicy last time when operating.</p>
        /// </summary>
        [JsonProperty("LastOperationInstanceTypesCheckPolicy")]
        public string LastOperationInstanceTypesCheckPolicy{ get; set; }

        /// <summary>
        /// <p>Related settings for the CVM host name (HostName).</p>
        /// </summary>
        [JsonProperty("HostNameSettings")]
        public HostNameSettings HostNameSettings{ get; set; }

        /// <summary>
        /// <p>Related settings for the cloud server instance name (InstanceName).</p>
        /// </summary>
        [JsonProperty("InstanceNameSettings")]
        public InstanceNameSettings InstanceNameSettings{ get; set; }

        /// <summary>
        /// <p>Prepaid mode, i.e., parameter settings related to monthly/annual subscription. By specifying this parameter, you can specify the purchase duration of annual and monthly subscription instances, whether to enable auto-renewal, and other attributes. This parameter is required if the billing mode for the specified instance is prepaid.</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>Cloud disk type selection policy. Parameter value range: <li>ORIGINAL: use the set cloud disk type</li><li>AUTOMATIC: automatically select available cloud disk types in the current AZ</li></p>
        /// </summary>
        [JsonProperty("DiskTypePolicy")]
        public string DiskTypePolicy{ get; set; }

        /// <summary>
        /// <p>Hyper Computing Cluster ID.<br><br>Note: This field is empty by default.</p>
        /// </summary>
        [JsonProperty("HpcClusterId")]
        public string HpcClusterId{ get; set; }

        /// <summary>
        /// <p>IPv6 public network bandwidth-related information settings.</p>
        /// </summary>
        [JsonProperty("IPv6InternetAccessible")]
        public IPv6InternetAccessible IPv6InternetAccessible{ get; set; }

        /// <summary>
        /// <p>Placement Group id. Only one can be specified.</p>
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>Image family name.</p>
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// <p>Local dedicated cluster ID.</p>
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// <p>ENI configuration of the launch configuration.</p>
        /// </summary>
        [JsonProperty("NetworkInterfaces")]
        public NetworkInterface[] NetworkInterfaces{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArrayObj(map, prefix + "AutoScalingGroupAbstractSet.", this.AutoScalingGroupAbstractSet);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationStatus", this.LaunchConfigurationStatus);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamArrayObj(map, prefix + "InstanceTags.", this.InstanceTags);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
            this.SetParamSimple(map, prefix + "LastOperationInstanceTypesCheckPolicy", this.LastOperationInstanceTypesCheckPolicy);
            this.SetParamObj(map, prefix + "HostNameSettings.", this.HostNameSettings);
            this.SetParamObj(map, prefix + "InstanceNameSettings.", this.InstanceNameSettings);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "DiskTypePolicy", this.DiskTypePolicy);
            this.SetParamSimple(map, prefix + "HpcClusterId", this.HpcClusterId);
            this.SetParamObj(map, prefix + "IPv6InternetAccessible.", this.IPv6InternetAccessible);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamArrayObj(map, prefix + "NetworkInterfaces.", this.NetworkInterfaces);
        }
    }
}

