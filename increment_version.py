from cgitb import text
from struct import pack
from xml.dom.minidom import Element
from xml.etree import ElementTree as ET


def increment_csproj_version(csproj):
    content = read_text(csproj)
    xml = ET.fromstring(content)
    version = xml.find('PropertyGroup/Version').text
    new_version = increment_version(version)
    xml.find('PropertyGroup/Version').text = new_version
    text = ET.tostring(xml).decode('utf-8')
    write_text(csproj, text)

def increment_csproj_reference_version(csproj):
    content = read_text(csproj)
    xml = ET.fromstring(content)
    version = xml.find('PropertyGroup/Version').text
    new_version = increment_version(version)
    xml.find('PropertyGroup/Version').text = new_version
    package_references = xml.findall('ItemGroup/ProjectReference')
    for package_reference in package_references:
        package_reference_include = package_reference.get('Include')
        package_reference_version = package_reference.get('Version')
        new_package_reference_version = increment_version(
            package_reference_version)
        if package_reference_include is not None and 'Onvif.' in package_reference_include:
            package_reference.set('Version', new_package_reference_version)
    text = ET.tostring(xml).decode('utf-8')
    write_text(csproj, text)

def increment_version(version):
    new_version = '.'.join(version.split(
        '.')[:-1] + [str(int(version.split('.')[-1]) + 1)])
    print(version, '->', new_version)
    return new_version


def write_text(csproj, text):
    with open(csproj, 'w') as f:
        f.write(text)


def read_text(csproj):
    with open(csproj, 'r', encoding='utf-8') as f:
        content = f.read()
    return content


if __name__ == '__main__':
    import sys
    if len(sys.argv) < 2:
        print('Usage: python increment_csproj.py <*.csproj>')
        exit(1)
    arg1 = sys.argv[1]
    increment_csproj_version(arg1)
