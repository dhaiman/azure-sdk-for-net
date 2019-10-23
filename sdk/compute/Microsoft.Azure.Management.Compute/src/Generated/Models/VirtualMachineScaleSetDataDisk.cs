// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set data disk.
    /// </summary>
    public partial class VirtualMachineScaleSetDataDisk
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetDataDisk
        /// class.
        /// </summary>
        public VirtualMachineScaleSetDataDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetDataDisk
        /// class.
        /// </summary>
        /// <param name="lun">Specifies the logical unit number of the data
        /// disk. This value is used to identify data disks within the VM and
        /// therefore must be unique for each data disk attached to a
        /// VM.</param>
        /// <param name="createOption">The create option. Possible values
        /// include: 'FromImage', 'Empty', 'Attach'</param>
        /// <param name="name">The disk name.</param>
        /// <param name="caching">Specifies the caching requirements.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt;
        /// **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt;
        /// **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="writeAcceleratorEnabled">Specifies whether
        /// writeAccelerator should be enabled or disabled on the disk.</param>
        /// <param name="diskSizeGB">Specifies the size of an empty data disk
        /// in gigabytes. This element can be used to overwrite the size of the
        /// disk in a virtual machine image. &lt;br&gt;&lt;br&gt; This value
        /// cannot be larger than 1023 GB</param>
        /// <param name="managedDisk">The managed disk parameters.</param>
        /// <param name="diskIOPSReadWrite">Specifies the Read-Write IOPS for
        /// the managed disk. Should be used only when StorageAccountType is
        /// UltraSSD_LRS. If not specified, a default value would be assigned
        /// based on diskSizeGB.</param>
        /// <param name="diskMBpsReadWrite">Specifies the bandwidth in MB per
        /// second for the managed disk. Should be used only when
        /// StorageAccountType is UltraSSD_LRS. If not specified, a default
        /// value would be assigned based on diskSizeGB.</param>
        public VirtualMachineScaleSetDataDisk(int lun, string createOption, string name = default(string), CachingTypes? caching = default(CachingTypes?), bool? writeAcceleratorEnabled = default(bool?), int? diskSizeGB = default(int?), VirtualMachineScaleSetManagedDiskParameters managedDisk = default(VirtualMachineScaleSetManagedDiskParameters), long? diskIOPSReadWrite = default(long?), long? diskMBpsReadWrite = default(long?))
        {
            Name = name;
            Lun = lun;
            Caching = caching;
            WriteAcceleratorEnabled = writeAcceleratorEnabled;
            CreateOption = createOption;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            DiskIOPSReadWrite = diskIOPSReadWrite;
            DiskMBpsReadWrite = diskMBpsReadWrite;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specifies the logical unit number of the data disk.
        /// This value is used to identify data disks within the VM and
        /// therefore must be unique for each data disk attached to a VM.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int Lun { get; set; }

        /// <summary>
        /// Gets or sets specifies the caching requirements.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **None**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadOnly**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadWrite**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets specifies whether writeAccelerator should be enabled
        /// or disabled on the disk.
        /// </summary>
        [JsonProperty(PropertyName = "writeAcceleratorEnabled")]
        public bool? WriteAcceleratorEnabled { get; set; }

        /// <summary>
        /// Gets or sets the create option. Possible values include:
        /// 'FromImage', 'Empty', 'Attach'
        /// </summary>
        [JsonProperty(PropertyName = "createOption")]
        public string CreateOption { get; set; }

        /// <summary>
        /// Gets or sets specifies the size of an empty data disk in gigabytes.
        /// This element can be used to overwrite the size of the disk in a
        /// virtual machine image. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; This
        /// value cannot be larger than 1023 GB
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets or sets the managed disk parameters.
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public VirtualMachineScaleSetManagedDiskParameters ManagedDisk { get; set; }

        /// <summary>
        /// Gets or sets specifies the Read-Write IOPS for the managed disk.
        /// Should be used only when StorageAccountType is UltraSSD_LRS. If not
        /// specified, a default value would be assigned based on diskSizeGB.
        /// </summary>
        [JsonProperty(PropertyName = "diskIOPSReadWrite")]
        public long? DiskIOPSReadWrite { get; set; }

        /// <summary>
        /// Gets or sets specifies the bandwidth in MB per second for the
        /// managed disk. Should be used only when StorageAccountType is
        /// UltraSSD_LRS. If not specified, a default value would be assigned
        /// based on diskSizeGB.
        /// </summary>
        [JsonProperty(PropertyName = "diskMBpsReadWrite")]
        public long? DiskMBpsReadWrite { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CreateOption == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CreateOption");
            }
        }
    }
}
